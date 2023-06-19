﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pg_explicit_preparation_with_autoprepare;

#nullable disable

namespace pg_explicit_preparation_with_autoprepare.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table1", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_1");

                    b.ToTable("table_1", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table10", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_10");

                    b.ToTable("table_10", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table11", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_11");

                    b.ToTable("table_11", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table12", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_12");

                    b.ToTable("table_12", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table13", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_13");

                    b.ToTable("table_13", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table14", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_14");

                    b.ToTable("table_14", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table15", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_15");

                    b.ToTable("table_15", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table16", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_16");

                    b.ToTable("table_16", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table17", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_17");

                    b.ToTable("table_17", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table2", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_2");

                    b.ToTable("table_2", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table3", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_3");

                    b.ToTable("table_3", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table4", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_4");

                    b.ToTable("table_4", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table5", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_5");

                    b.ToTable("table_5", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table6", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_6");

                    b.ToTable("table_6", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table7", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_7");

                    b.ToTable("table_7", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table8", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_8");

                    b.ToTable("table_8", (string)null);
                });

            modelBuilder.Entity("pg_explicit_preparation_with_autoprepare.Table9", b =>
                {
                    b.Property<int>("TenantId")
                        .HasColumnType("integer")
                        .HasColumnName("tenant_id");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TenantId", "Id")
                        .HasName("pk_table_9");

                    b.ToTable("table_9", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}