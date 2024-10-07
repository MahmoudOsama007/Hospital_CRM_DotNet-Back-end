using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1_Blue_Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataHospitalV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VerySpecificSpecialistId",
                table: "VerySpecificSpecialists",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MinorSpecialistId",
                table: "MinorSpecialists",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MajorSpecialistId",
                table: "MajorSpecialists",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "HospitalId",
                table: "Hospitals",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Doctors",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VerySpecificSpecialists",
                newName: "VerySpecificSpecialistId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MinorSpecialists",
                newName: "MinorSpecialistId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MajorSpecialists",
                newName: "MajorSpecialistId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Hospitals",
                newName: "HospitalId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Doctors",
                newName: "DoctorId");
        }
    }
}
