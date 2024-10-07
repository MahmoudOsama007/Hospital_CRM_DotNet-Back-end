using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1_Blue_Api.Migrations
{
    /// <inheritdoc />
    public partial class ticketv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignedAreaId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedCityId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedCompanyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandLineNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientNumber = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    CallTypeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CallAboutId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CallServiceId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedHospitalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MajorSpecialistId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinorSpecialistId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerySpecificSpecialistId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CustomerId",
                table: "Tickets",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
