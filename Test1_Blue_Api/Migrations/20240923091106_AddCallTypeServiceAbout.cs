using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Test1_Blue_Api.Migrations
{
    /// <inheritdoc />
    public partial class AddCallTypeServiceAbout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CallTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CallAbouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CallTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallAbouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CallAbouts_CallTypes_CallTypeId",
                        column: x => x.CallTypeId,
                        principalTable: "CallTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CallServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CallAboutId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CallServices_CallAbouts_CallAboutId",
                        column: x => x.CallAboutId,
                        principalTable: "CallAbouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CallTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Technical Support" },
                    { 2, "Billing" },
                    { 3, "General Inquiry" }
                });

            migrationBuilder.InsertData(
                table: "CallAbouts",
                columns: new[] { "Id", "CallTypeId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Product Issue" },
                    { 2, 1, "Account Access" },
                    { 3, 2, "Payment Method" },
                    { 4, 2, "Invoice Query" },
                    { 5, 3, "Service Availability" }
                });

            migrationBuilder.InsertData(
                table: "CallServices",
                columns: new[] { "Id", "CallAboutId", "Name" },
                values: new object[,]
                {
                    { 1, 2, "Reset Password" },
                    { 2, 1, "Check Order Status" },
                    { 3, 3, "Update Payment Info" },
                    { 4, 4, "Request Invoice Copy" },
                    { 5, 5, "Check Service Location" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CallAbouts_CallTypeId",
                table: "CallAbouts",
                column: "CallTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CallServices_CallAboutId",
                table: "CallServices",
                column: "CallAboutId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CallServices");

            migrationBuilder.DropTable(
                name: "CallAbouts");

            migrationBuilder.DropTable(
                name: "CallTypes");
        }
    }
}
