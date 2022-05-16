using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientManagementApp.Migrations
{
    public partial class PMA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatientDetail_Doctor_doctorid",
                table: "DoctorPatientDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatientDetail_PatientDetail_patientDetailsid",
                table: "DoctorPatientDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientProblems_PatientDetail_PatientDetailId",
                table: "PatientProblems");

            migrationBuilder.DropIndex(
                name: "IX_PatientProblems_PatientDetailId",
                table: "PatientProblems");

            migrationBuilder.DropColumn(
                name: "consulationAmount",
                table: "PatientDetail");

            migrationBuilder.DropColumn(
                name: "contact",
                table: "Doctor");

            migrationBuilder.RenameColumn(
                name: "problemType",
                table: "PatientProblems",
                newName: "ProblemType");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "PatientProblems",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "PatientProblems",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PatientDetailId",
                table: "PatientProblems",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "PatientMedications",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "PatientMedications",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "timesInPerDay",
                table: "PatientMedications",
                newName: "TimesPerDay");

            migrationBuilder.RenameColumn(
                name: "typeOfPayment",
                table: "PatientDetail",
                newName: "TypeOfPayment");

            migrationBuilder.RenameColumn(
                name: "totalBill",
                table: "PatientDetail",
                newName: "TotalBill");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "PatientDetail",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "PatientDetail",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "doctorToAttend",
                table: "PatientDetail",
                newName: "DoctorToAttend");

            migrationBuilder.RenameColumn(
                name: "doctorId",
                table: "PatientDetail",
                newName: "DoctorId");

            migrationBuilder.RenameColumn(
                name: "doctorFees",
                table: "PatientDetail",
                newName: "DoctorFees");

            migrationBuilder.RenameColumn(
                name: "discount",
                table: "PatientDetail",
                newName: "Discount");

            migrationBuilder.RenameColumn(
                name: "dateOfBirth",
                table: "PatientDetail",
                newName: "DOB");

            migrationBuilder.RenameColumn(
                name: "countryName",
                table: "PatientDetail",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "PatientDetail",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "doctorid",
                table: "DoctorPatientDetail",
                newName: "DoctorId");

            migrationBuilder.RenameColumn(
                name: "patientDetailsid",
                table: "DoctorPatientDetail",
                newName: "PatientDetailsPatientId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorPatientDetail_patientDetailsid",
                table: "DoctorPatientDetail",
                newName: "IX_DoctorPatientDetail_PatientDetailsPatientId");

            migrationBuilder.RenameColumn(
                name: "specialist",
                table: "Doctor",
                newName: "Specialist");

            migrationBuilder.RenameColumn(
                name: "qualification",
                table: "Doctor",
                newName: "Qualification");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Doctor",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Doctor",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Doctor",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Doctor",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "PatientDetailIdPatientId",
                table: "PatientProblems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientProblems_PatientDetailIdPatientId",
                table: "PatientProblems",
                column: "PatientDetailIdPatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatientDetail_Doctor_DoctorId",
                table: "DoctorPatientDetail",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatientDetail_PatientDetail_PatientDetailsPatientId",
                table: "DoctorPatientDetail",
                column: "PatientDetailsPatientId",
                principalTable: "PatientDetail",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientProblems_PatientDetail_PatientDetailIdPatientId",
                table: "PatientProblems",
                column: "PatientDetailIdPatientId",
                principalTable: "PatientDetail",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatientDetail_Doctor_DoctorId",
                table: "DoctorPatientDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatientDetail_PatientDetail_PatientDetailsPatientId",
                table: "DoctorPatientDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientProblems_PatientDetail_PatientDetailIdPatientId",
                table: "PatientProblems");

            migrationBuilder.DropIndex(
                name: "IX_PatientProblems_PatientDetailIdPatientId",
                table: "PatientProblems");

            migrationBuilder.DropColumn(
                name: "PatientDetailIdPatientId",
                table: "PatientProblems");

            migrationBuilder.RenameColumn(
                name: "ProblemType",
                table: "PatientProblems",
                newName: "problemType");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "PatientProblems",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PatientProblems",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "PatientProblems",
                newName: "PatientDetailId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "PatientMedications",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PatientMedications",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TimesPerDay",
                table: "PatientMedications",
                newName: "timesInPerDay");

            migrationBuilder.RenameColumn(
                name: "TypeOfPayment",
                table: "PatientDetail",
                newName: "typeOfPayment");

            migrationBuilder.RenameColumn(
                name: "TotalBill",
                table: "PatientDetail",
                newName: "totalBill");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "PatientDetail",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "PatientDetail",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "DoctorToAttend",
                table: "PatientDetail",
                newName: "doctorToAttend");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "PatientDetail",
                newName: "doctorId");

            migrationBuilder.RenameColumn(
                name: "DoctorFees",
                table: "PatientDetail",
                newName: "doctorFees");

            migrationBuilder.RenameColumn(
                name: "Discount",
                table: "PatientDetail",
                newName: "discount");

            migrationBuilder.RenameColumn(
                name: "DOB",
                table: "PatientDetail",
                newName: "dateOfBirth");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "PatientDetail",
                newName: "countryName");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "PatientDetail",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "DoctorPatientDetail",
                newName: "doctorid");

            migrationBuilder.RenameColumn(
                name: "PatientDetailsPatientId",
                table: "DoctorPatientDetail",
                newName: "patientDetailsid");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorPatientDetail_PatientDetailsPatientId",
                table: "DoctorPatientDetail",
                newName: "IX_DoctorPatientDetail_patientDetailsid");

            migrationBuilder.RenameColumn(
                name: "Specialist",
                table: "Doctor",
                newName: "specialist");

            migrationBuilder.RenameColumn(
                name: "Qualification",
                table: "Doctor",
                newName: "qualification");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Doctor",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Doctor",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Doctor",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Doctor",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "consulationAmount",
                table: "PatientDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "contact",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PatientProblems_PatientDetailId",
                table: "PatientProblems",
                column: "PatientDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatientDetail_Doctor_doctorid",
                table: "DoctorPatientDetail",
                column: "doctorid",
                principalTable: "Doctor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatientDetail_PatientDetail_patientDetailsid",
                table: "DoctorPatientDetail",
                column: "patientDetailsid",
                principalTable: "PatientDetail",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientProblems_PatientDetail_PatientDetailId",
                table: "PatientProblems",
                column: "PatientDetailId",
                principalTable: "PatientDetail",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
