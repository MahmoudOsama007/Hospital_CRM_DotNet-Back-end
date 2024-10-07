using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1_Blue_Api.Migrations
{
    /// <inheritdoc />
    public partial class addsofttocalls2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "CallTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CallTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "CallTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "CallServices",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CallServices",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "CallServices",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteAt",
                table: "CallAbouts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CallAbouts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "CallAbouts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallAbouts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallServices",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "CallTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DeleteAt", "IsDeleted", "UpdateAt" },
                values: new object[] { null, false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "CallTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CallTypes");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "CallTypes");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "CallServices");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CallServices");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "CallServices");

            migrationBuilder.DropColumn(
                name: "DeleteAt",
                table: "CallAbouts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CallAbouts");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "CallAbouts");
        }
    }
}
