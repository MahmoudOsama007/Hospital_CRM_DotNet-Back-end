using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1_Blue_Api.Migrations
{
    /// <inheritdoc />
    public partial class SoftDeleteCommenV1Inhert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "Companys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Companys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2355), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2357), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2359), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2361), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2362), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2364), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2365), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2367), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2368), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2369), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2371), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2372), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2374), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2375), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2377), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2378), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2379), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2381), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2382), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2384), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2385), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2386), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2388), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2390), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2391), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2393), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2394), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2396), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2397), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2398), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2400), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2401), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2403), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2404), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2406), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2407), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2166), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2207), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2209), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2211), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2212), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2214), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2215), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2216), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2218), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2219), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "Companys");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Companys");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Areas");
        }
    }
}
