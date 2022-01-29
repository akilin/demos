using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace pg_related_entities
{
    static class Program
    {
        static void Main(string[] args)
        {
            using var ctx = new AppContext();
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();


            var user = new User();
            var thingThasHasUser = new ThingThatHasUser { User = user };
            ctx.SaveChanges();
        }
    }

    public class User
    {
        public int Id { get; set; }
    }

    public class ThingThatHasUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }

    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ThingThatHasUser> Things { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=test;Username=guest;Password=pwd")
            .UseSnakeCaseNamingConvention();

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ThingThatHasUser>().HasOne(x => x.User).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}