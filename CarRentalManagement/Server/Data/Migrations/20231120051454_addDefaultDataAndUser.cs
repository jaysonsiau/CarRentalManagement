using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class addDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "firstName", "lastName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d6334f70-5577-4492-b892-c7d34a97a92c", "admin@localhost.com", false, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEB/usPwo0HjTCdxrhVfnXmG/kQ05PJz/S0X96yZh/wthOLnmzevm+k4xilN/6QjIBw==", null, false, "44eae11c-b833-477c-bc30-2c762f87d6bc", false, "admin@localhost.com", "Admin", "User" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(8555), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(8572), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(8581), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(8583), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9371), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9374), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9377), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9378), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9773), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9775), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9779), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9780), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9782), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9783), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9786), new DateTime(2023, 11, 20, 13, 14, 54, 255, DateTimeKind.Local).AddTicks(9787), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
