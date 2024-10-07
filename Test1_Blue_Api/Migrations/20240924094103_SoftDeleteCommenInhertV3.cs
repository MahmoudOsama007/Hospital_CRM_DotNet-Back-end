using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1_Blue_Api.Migrations
{
    /// <inheritdoc />
    public partial class SoftDeleteCommenInhertV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Customers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteAt",
                table: "Customers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Companys",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteAt",
                table: "Companys",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteAt",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Areas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteAt",
                table: "Areas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9842), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9845), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9846), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9848), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9849), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9851), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9852), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9854), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9855), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9857), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9858), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9860), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9861), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9863), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9864), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9865), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9867), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9868), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9870), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9871), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9872), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9874), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9875), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9878), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9879), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9880), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9882), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9883), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9885), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9886), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9887), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9889), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9890), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9892), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9893), null });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9895), null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9661), null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9709), null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9712), null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9713), null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9715), null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9716), null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9718), null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9719), null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9721), null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 41, 3, 232, DateTimeKind.Local).AddTicks(9722), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteAt",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Companys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteAt",
                table: "Companys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteAt",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateAt",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteAt",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9126), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9129), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9131), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9132), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9134), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9135), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9137), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9139), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9141), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9142), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9144), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9145), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9147), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9149), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9150), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9152), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9153), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9155), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9156), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9158), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9159), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9161), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9163), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9164), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9166), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9167), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9169), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9170), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9172), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9173), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9175), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9176), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9178), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9179), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9181), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9183), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(8943), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(8988), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(8990), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(8992), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(8994), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9007), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9010), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9011), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9012), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeleteAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 24, 12, 26, 24, 684, DateTimeKind.Local).AddTicks(9014), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
