using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientManagementApp.Migrations
{
    public partial class PMA3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "PatientProblems",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "PatientProblems");
        }
    }
}
