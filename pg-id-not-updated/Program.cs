using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Diagnostics;
using System.Linq;

namespace pg_id_not_updated;

static class Program
{
    static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();

        using var ctx = new TestContext();

        ctx.Database.EnsureDeleted();
        ctx.Database.EnsureCreated();

        var tenant = new Tenant { Name = "testing returned ids" };
        ctx.Tenants.Add(tenant);
        ctx.SaveChanges();

        //this section is just to demonstrate that id in db is different.
        var dbTenant = ctx.Tenants.AsNoTracking().FirstOrDefault(x => x.Name == tenant.Name);
        if (dbTenant.Id != tenant.Id)
        {
            Log.Error("Id was not updated. InMemory id is {appId}, while db id is {dbId}", tenant.Id, dbTenant.Id);
        }
    }

}

public class Tenant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? DefaultRoleId { get; set; }
    public Role DefaultRole { get; set; }
}

public class Role
{
    public int TenantId { get; set; }
    public Tenant Tenant { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
}

public class TestContext : DbContext
{
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<Role> Roles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
        .UseNpgsql("Host=localhost;Database=test;Username=guest;Password=pwd")
        .UseSnakeCaseNamingConvention()
        .UseLoggerFactory(new LoggerFactory().AddSerilog(Log.Logger));

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.UseIdentityAlwaysColumns();

        mb.Entity<Tenant>().HasKey(x => x.Id);
        mb.Entity<Tenant>().Property(x => x.Id).UseIdentityAlwaysColumn()
            .Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Throw);

        mb.Entity<Tenant>().HasOne(x => x.DefaultRole)
            .WithOne()
            .HasForeignKey<Tenant>(x => new { x.Id, x.DefaultRoleId });


        mb.Entity<Role>().HasKey(x => new { x.TenantId, x.Id });
        mb.Entity<Role>().HasOne(x => x.Tenant).WithMany().HasForeignKey(x => new { x.TenantId });
    }
}
