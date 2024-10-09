using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1_Blue_Api.Migrations
{
    /// <inheritdoc />
    public partial class editticketv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "LandLineNumber",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "OtherPhoneNumber",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PatientNumber",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Tickets");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandLineNumber",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherPhoneNumber",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientNumber",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
