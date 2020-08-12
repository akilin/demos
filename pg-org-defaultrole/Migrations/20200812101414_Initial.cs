using Microsoft.EntityFrameworkCore.Migrations;

namespace pg_org_defaultrole.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    org_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_roles", x => new { x.org_id, x.id });
                });

            migrationBuilder.CreateTable(
                name: "orgs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    default_role_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_orgs", x => x.id);
                });

            migrationBuilder.Sql(@"
ALTER TABLE orgs
ADD  CONSTRAINT fk_orgs_roles_id_default_role_id 
FOREIGN KEY (id, default_role_id) REFERENCES roles (org_id, id) ON DELETE CASCADE DEFERRABLE INITIALLY DEFERRED;");

            migrationBuilder.CreateIndex(
                name: "ix_orgs_id_default_role_id",
                table: "orgs",
                columns: new[] { "id", "default_role_id" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_roles_orgs_org_id",
                table: "roles",
                column: "org_id",
                principalTable: "orgs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_orgs_roles_id_default_role_id",
                table: "orgs");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "orgs");
        }
    }
}
