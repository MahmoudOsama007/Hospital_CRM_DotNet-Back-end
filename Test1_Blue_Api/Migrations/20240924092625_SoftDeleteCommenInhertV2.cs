using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1_Blue_Api.Migrations
{
    /// <inheritdoc />
    public partial class SoftDeleteCommenInhertV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Companys",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Cities",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Areas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9126), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9129), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9131), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9132), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9134), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9135), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9137), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9139), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9141), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9142), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9144), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9145), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9147), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9149), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9150), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9152), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9153), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9155), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9156), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9158), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9159), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9161), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9163), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9164), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9166), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9167), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9169), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9170), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9172), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9173), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9175), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9176), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9178), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9179), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9181), false });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9183), false });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(8943), false });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(8988), false });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(8990), false });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(8992), false });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(8994), false });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9007), false });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9010), false });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9011), false });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9012), false });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeleteAt", "IsDeleted" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9014), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Companys");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Areas");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 7,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 8,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 9,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 10,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 11,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 12,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 13,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 14,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 15,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 16,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 17,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 18,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 19,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 20,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 21,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 22,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 23,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 24,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 25,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 26,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 27,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 28,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 29,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 30,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 31,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 32,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 33,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 34,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 35,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 36,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "DeleteAt",
                value: new DateTime(2024, 9, 24, 12, 23, 40, 91, DateTimeKind.Local).AddTicks(2219));
        }
    }
}
