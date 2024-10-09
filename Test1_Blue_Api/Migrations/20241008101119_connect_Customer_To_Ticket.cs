using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1_Blue_Api.Migrations
{
    /// <inheritdoc />
    public partial class connect_Customer_To_Ticket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedAreaId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "AssignedCityId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "AssignedCompanyId",
                table: "Tickets");

            migrationBuilder.AddColumn<int>(
                name: "TicketNumber",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketNumber",
                table: "Tickets");

            migrationBuilder.AddColumn<string>(
                name: "AssignedAreaId",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssignedCityId",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssignedCompanyId",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
