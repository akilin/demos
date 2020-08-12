using Microsoft.EntityFrameworkCore.Migrations;

namespace pg_org_defaultrole.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    OrgId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => new { x.OrgId, x.Id });
                });

            migrationBuilder.CreateTable(
                name: "Orgs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DefaultRoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orgs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orgs_Roles_Id_DefaultRoleId",
                        columns: x => new { x.Id, x.DefaultRoleId },
                        principalTable: "Roles",
                        principalColumns: new[] { "OrgId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orgs_Id_DefaultRoleId",
                table: "Orgs",
                columns: new[] { "Id", "DefaultRoleId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Orgs_OrgId",
                table: "Roles",
                column: "OrgId",
                principalTable: "Orgs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orgs_Roles_Id_DefaultRoleId",
                table: "Orgs");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Orgs");
        }
    }
}
