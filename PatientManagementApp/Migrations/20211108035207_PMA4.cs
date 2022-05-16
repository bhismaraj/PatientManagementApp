using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientManagementApp.Migrations
{
    public partial class PMA4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "PatientDetail",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sex",
                table: "PatientDetail");
        }
    }
}
