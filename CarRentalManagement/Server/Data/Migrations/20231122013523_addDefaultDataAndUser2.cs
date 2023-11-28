using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class addDefaultDataAndUser2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83bd585c-7869-4599-93c4-79eb7dbb0599", "AQAAAAIAAYagAAAAEHPJP+vNk+94rrnqTE5Ed+n+O/rNpOYOjmzBMGVGA9IQ3Qbg0wvOJNDE3GY/y+YmZg==", "f5a6d683-725c-4093-8d8a-3b92ced23a90" });

            migrationBuilder.UpdateData(
                // Adding new data does not result in data duplication.
                // The old data will be overwritten.
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(4194), new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(4216), new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(4861), new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(4866), new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(5263), new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(5268), new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(5271), new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(5275), new DateTime(2023, 11, 22, 9, 35, 22, 933, DateTimeKind.Local).AddTicks(5276) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6334f70-5577-4492-b892-c7d34a97a92c", "AQAAAAIAAYagAAAAEB/usPwo0HjTCdxrhVfnXmG/kQ05PJz/S0X96yZh/wthOLnmzevm+k4xilN/6QjIBw==", "44eae11c-b833-477c-bc30-2c762f87d6bc" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(8555), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(8581), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9371), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9377), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9773), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9779), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9782), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9786), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9787) });
        }
    }
}
