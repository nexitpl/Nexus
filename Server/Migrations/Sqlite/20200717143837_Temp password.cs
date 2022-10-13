using Microsoft.EntityFrameworkCore.Migrations;

namespace Nexus.Server.Migrations.Sqlite
{
    public partial class Temppassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TempPassword",
                table: "NexusUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TempPassword",
                table: "NexusUsers");
        }
    }
}
