using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUser : Migration
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "3b462d44-bc1f-4487-8622-c566194634b2", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPkNUbCylLm5fBVNURFBk2BMBCbPVMR/4QgSit3sszgTQw//2sZ/k6g7hA87PNrhvQ==", null, false, "3fe62ec9-3f09-4bcc-9194-2bb9b467dac8", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(972), new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(988), new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(1478), new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(1482), new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(1871), new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(1876), new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(1880), new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(1883), new DateTime(2023, 11, 22, 11, 29, 13, 758, DateTimeKind.Local).AddTicks(1884) });

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(6186), new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(6201), new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(6833), new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(6838), new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(7261), new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(7265), new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(7269), new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(7272), new DateTime(2023, 11, 22, 11, 16, 32, 222, DateTimeKind.Local).AddTicks(7273) });
        }
    }
}
