using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pg_explicit_preparation.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "table_1",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_1", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_10",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_10", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_11",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_11", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_12",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_12", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_13",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_13", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_14",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_14", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_15",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_15", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_16",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_16", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_17",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_17", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_2",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_2", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_3",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_3", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_4",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_4", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_5",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_5", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_6",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_6", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_7",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_7", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_8",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_8", x => new { x.tenant_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "table_9",
                columns: table => new
                {
                    tenant_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_table_9", x => new { x.tenant_id, x.id });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "table_1");

            migrationBuilder.DropTable(
                name: "table_10");

            migrationBuilder.DropTable(
                name: "table_11");

            migrationBuilder.DropTable(
                name: "table_12");

            migrationBuilder.DropTable(
                name: "table_13");

            migrationBuilder.DropTable(
                name: "table_14");

            migrationBuilder.DropTable(
                name: "table_15");

            migrationBuilder.DropTable(
                name: "table_16");

            migrationBuilder.DropTable(
                name: "table_17");

            migrationBuilder.DropTable(
                name: "table_2");

            migrationBuilder.DropTable(
                name: "table_3");

            migrationBuilder.DropTable(
                name: "table_4");

            migrationBuilder.DropTable(
                name: "table_5");

            migrationBuilder.DropTable(
                name: "table_6");

            migrationBuilder.DropTable(
                name: "table_7");

            migrationBuilder.DropTable(
                name: "table_8");

            migrationBuilder.DropTable(
                name: "table_9");
        }
    }
}
