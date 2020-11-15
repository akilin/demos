using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Collections.Generic;

namespace pg_multiplexing_pooling
{
    static class Program
    {
        static void Main(string[] args)
        {
            using var ctx = new AppContext();
            ctx.Database.EnsureDeleted();
            ctx.Database.Migrate();
        }
    }

    public class AppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                new NpgsqlConnectionStringBuilder
                {
                    Host = "localhost",
                    Database = "test",
                    Username = "guest",
                    Password = "pwd",
                    Pooling = true,
                    Multiplexing = true
                }.ToString());
    }
}