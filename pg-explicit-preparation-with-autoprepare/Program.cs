using System;
using Microsoft.EntityFrameworkCore;
using NpgsqlTypes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics;
using Npgsql;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace pg_explicit_preparation_with_autoprepare
{
    static class Program
    {

        static void Main()
        {
            var sql = @"select count(*) from table_1
join table_2 using (tenant_id, id)
join table_3 using (tenant_id, id)
join table_4 using (tenant_id, id)
join table_5 using (tenant_id, id)
join table_6 using (tenant_id, id)
join table_7 using (tenant_id, id)
join table_8 using (tenant_id, id)
join table_9 using (tenant_id, id)
join table_10 using (tenant_id, id)
join table_11 using (tenant_id, id)
join table_12 using (tenant_id, id)
join table_13 using (tenant_id, id)
join table_14 using (tenant_id, id)
join table_15 using (tenant_id, id)
join table_16 using (tenant_id, id)
join table_17 using (tenant_id, id)
join table_18 using (tenant_id, id)
join table_19 using (tenant_id, id)
join table_20 using (tenant_id, id)
join table_21 using (tenant_id, id)
join table_22 using (tenant_id, id)
join table_23 using (tenant_id, id)
join table_24 using (tenant_id, id)
join table_25 using (tenant_id, id)
join table_26 using (tenant_id, id)
join table_27 using (tenant_id, id)
join table_28 using (tenant_id, id)
join table_29 using (tenant_id, id)
join table_30 using (tenant_id, id)
";

            sql += "where tenant_id = @tenantId and id = @id";

            using var ctx = new AppContext();

            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();

            var sw = new Stopwatch();

            for (int i = 0; i < 20; i++)
            {
                var con = ctx.Database.GetDbConnection() as NpgsqlConnection;
                if (con.State is not ConnectionState.Open) con.Open();

                sw.Restart();

                using var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.Add("tenantId", NpgsqlDbType.Integer);
                cmd.Parameters.Add("id", NpgsqlDbType.Integer);

                cmd.Prepare();

                cmd.Parameters["tenantId"].Value = i;
                cmd.Parameters["id"].Value = i;

                cmd.ExecuteScalar();

                Console.WriteLine(i + "\t" + con.ProcessID + "\t" + sw.Elapsed);
            }
        }
    }

    public class BaseEntity
    {
        public int TenantId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [Table("table_1")] public class Table1 : BaseEntity { }
    [Table("table_2")] public class Table2 : BaseEntity { }
    [Table("table_3")] public class Table3 : BaseEntity { }
    [Table("table_4")] public class Table4 : BaseEntity { }
    [Table("table_5")] public class Table5 : BaseEntity { }
    [Table("table_6")] public class Table6 : BaseEntity { }
    [Table("table_7")] public class Table7 : BaseEntity { }
    [Table("table_8")] public class Table8 : BaseEntity { }
    [Table("table_9")] public class Table9 : BaseEntity { }
    [Table("table_10")] public class Table10 : BaseEntity { }
    [Table("table_11")] public class Table11 : BaseEntity { }
    [Table("table_12")] public class Table12 : BaseEntity { }
    [Table("table_13")] public class Table13 : BaseEntity { }
    [Table("table_14")] public class Table14 : BaseEntity { }
    [Table("table_15")] public class Table15 : BaseEntity { }
    [Table("table_16")] public class Table16 : BaseEntity { }
    [Table("table_17")] public class Table17 : BaseEntity { }
    [Table("table_18")] public class Table18 : BaseEntity { }
    [Table("table_19")] public class Table19 : BaseEntity { }
    [Table("table_20")] public class Table20 : BaseEntity { }
    [Table("table_21")] public class Table21 : BaseEntity { }
    [Table("table_22")] public class Table22 : BaseEntity { }
    [Table("table_23")] public class Table23 : BaseEntity { }
    [Table("table_24")] public class Table24 : BaseEntity { }
    [Table("table_25")] public class Table25 : BaseEntity { }
    [Table("table_26")] public class Table26 : BaseEntity { }
    [Table("table_27")] public class Table27 : BaseEntity { }
    [Table("table_28")] public class Table28 : BaseEntity { }
    [Table("table_29")] public class Table29 : BaseEntity { }
    [Table("table_30")] public class Table30 : BaseEntity { }

    public class AppContext : DbContext
    {
        public DbSet<Table1> Table1 { get; set; }
        public DbSet<Table2> Table2 { get; set; }
        public DbSet<Table3> Table3 { get; set; }
        public DbSet<Table4> Table4 { get; set; }
        public DbSet<Table5> Table5 { get; set; }
        public DbSet<Table6> Table6 { get; set; }
        public DbSet<Table7> Table7 { get; set; }
        public DbSet<Table8> Table8 { get; set; }
        public DbSet<Table9> Table9 { get; set; }
        public DbSet<Table10> Table10 { get; set; }
        public DbSet<Table11> Table11 { get; set; }
        public DbSet<Table12> Table12 { get; set; }
        public DbSet<Table13> Table13 { get; set; }
        public DbSet<Table14> Table14 { get; set; }
        public DbSet<Table15> Table15 { get; set; }
        public DbSet<Table16> Table16 { get; set; }
        public DbSet<Table17> Table17 { get; set; }
        public DbSet<Table18> Table18 { get; set; }
        public DbSet<Table19> Table19 { get; set; }
        public DbSet<Table20> Table20 { get; set; }
        public DbSet<Table21> Table21 { get; set; }
        public DbSet<Table22> Table22 { get; set; }
        public DbSet<Table23> Table23 { get; set; }
        public DbSet<Table24> Table24 { get; set; }
        public DbSet<Table25> Table25 { get; set; }
        public DbSet<Table26> Table26 { get; set; }
        public DbSet<Table27> Table27 { get; set; }
        public DbSet<Table28> Table28 { get; set; }
        public DbSet<Table29> Table29 { get; set; }
        public DbSet<Table29> Table30 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=test;Username=guest;Password=pwd").UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Table1>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table2>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table3>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table4>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table5>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table6>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table7>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table8>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table9>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table10>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table11>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table12>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table13>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table14>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table15>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table16>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table17>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table18>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table19>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table20>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table21>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table22>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table23>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table24>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table25>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table26>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table27>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table28>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table29>().HasKey(x => new { x.TenantId, x.Id });
            mb.Entity<Table30>().HasKey(x => new { x.TenantId, x.Id });
        }
    }
}