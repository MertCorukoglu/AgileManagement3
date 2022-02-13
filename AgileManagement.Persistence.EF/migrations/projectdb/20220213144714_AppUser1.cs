using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileManagement.Persistence.EF.migrations.projectdb
{
    public partial class AppUser1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SprintName",
                table: "Sprint",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SprintName",
                table: "Sprint");
        }
    }
}
