﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace pg_org_defaultrole
{
    static class Program
    {
        static void Main(string[] args)
        {
            using var ctx = new AppContext();
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
            var role = new Role();
            var org = new Org
            {
                DefaultRole = role,
                Roles = new[] { role }
            };
            ctx.Add(org);
            ctx.SaveChanges();
        }
    }

    public class Org
    {
        public int Id { get; set; }
        public int DefaultRoleId { get; set; }
        public Role DefaultRole { get; set; }
        public ICollection<Role> Roles { get; set; }
    }

    public class Role
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public Org Org { get; set; }
    }

    public class AppContext : DbContext
    {
        public DbSet<Org> Orgs { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=test;Username=guest;Password=pwd");

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Org>().HasOne(x => x.DefaultRole);
            mb.Entity<Role>().HasKey(x => new { x.OrgId, x.Id });
            mb.Entity<Role>().HasOne(x => x.Org).WithMany(x => x.Roles).HasForeignKey(x => new { x.OrgId });
        }
    }
}