using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientManagementApp.Migrations
{
    public partial class PMA2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "PatientDetail",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "PatientDetail");
        }
    }
}
