using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Test1_Blue_Api.Migrations
{
    /// <inheritdoc />
    public partial class addsofttocalls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CallTypes",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 4, true, "Appointment Scheduling" },
                    { 5, true, "Patient Information" },
                    { 6, true, "Medical Records" },
                    { 7, true, "Insurance Inquiry" }
                });

            migrationBuilder.InsertData(
                table: "CallAbouts",
                columns: new[] { "Id", "CallTypeId", "IsActive", "Name" },
                values: new object[,]
                {
                    { 6, 4, true, "Schedule an Appointment" },
                    { 7, 4, true, "Change Appointment" },
                    { 8, 4, true, "Check Appointment Status" },
                    { 9, 5, true, "Update Patient Info" },
                    { 10, 6, true, "Request Medical Records" },
                    { 11, 7, true, "Insurance Coverage Details" },
                    { 12, 7, true, "Claim Status" }
                });

            migrationBuilder.InsertData(
                table: "CallServices",
                columns: new[] { "Id", "CallAboutId", "IsActive", "Name" },
                values: new object[,]
                {
                    { 6, 6, true, "Book Appointment" },
                    { 7, 7, true, "Cancel Appointment" },
                    { 8, 8, true, "View Appointment Details" },
                    { 9, 9, true, "Edit Patient Information" },
                    { 10, 10, true, "Get Medical Records" },
                    { 11, 11, true, "Submit Insurance Claim" },
                    { 12, 12, true, "Check Claim Status" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CallTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CallTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CallTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CallTypes",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
