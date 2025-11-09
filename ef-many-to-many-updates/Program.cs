using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace pg_related_entities
{
    static class Program
    {
        static void Main(string[] args)
        {
            // reset db
            using var ctx = new AppContext();
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();

            // seed data
            ctx.Groups.Add(new Group());
            ctx.Users.Add(new User());
            ctx.SaveChanges();
            ctx.GroupMembers.Add(new GroupMember { UserId = 1, GroupId = 1 });
            ctx.SaveChanges();

            ctx.ChangeTracker.Clear();

            // act
            var group = ctx.Groups.Include(x => x.Members).Single();
            //either of the 2 lines below work fine on their own. but combined - they cause the issue
            group.Members = [new() { UserId = 1, GroupId = 1 }];
            group.GroupOwnerId = 1;
            ctx.SaveChanges();
        }
    }

    public class User
    {
        public int Id { get; set; }
        public ICollection<GroupMember> Groups { get; set; } = null!;
    }

    public class Group
    {
        public int Id { get; set; }
        public int? GroupOwnerId { get; set; }
        public GroupMember? GroupOwner { get; set; }
        public ICollection<GroupMember> Members { get; set; } = null!;
    }

    public class GroupMember
    {
        public int GroupId { get; set; }
        public Group Group { get; set; } = null!;

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }

    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupMember> GroupMembers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information)
            .EnableSensitiveDataLogging()
            .EnableDetailedErrors()
            .UseNpgsql("Host=localhost;Database=test;Username=guest;Password=pwd")
            .UseSnakeCaseNamingConvention();

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<User>().HasKey(x => new { x.Id });
            var userId = mb.Entity<User>().Property(x => x.Id);
            userId.UseIdentityAlwaysColumn();
            userId.Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Throw);
            userId.Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Throw);

            mb.Entity<Group>().HasKey(x => new { x.Id });
            var groupId = mb.Entity<Group>().Property(x => x.Id);
            groupId.UseIdentityAlwaysColumn();
            groupId.Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Throw);
            groupId.Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Throw);

            mb.Entity<Group>()
                .HasOne(x => x.GroupOwner)
                .WithMany()
                .HasForeignKey(x => new { x.Id, x.GroupOwnerId })
                .OnDelete(DeleteBehavior.Restrict);

            mb.Entity<GroupMember>().HasKey(x => new { x.GroupId, x.UserId });

            mb.Entity<GroupMember>()
                .HasOne(x => x.User)
                .WithMany(x => x.Groups)
                .HasForeignKey(x => new { x.UserId })
                .OnDelete(DeleteBehavior.Cascade);

            mb.Entity<GroupMember>()
                .HasOne(x => x.Group)
                .WithMany(x => x.Members)
                .HasForeignKey(x => new { x.GroupId })
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}