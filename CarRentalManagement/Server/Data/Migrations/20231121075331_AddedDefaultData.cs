using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(8677), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(8691), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(8693), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9007), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9008), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9012), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9013), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9178), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9179), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9180), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9180), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9182), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9182), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9183), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9184), "Rav4", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
