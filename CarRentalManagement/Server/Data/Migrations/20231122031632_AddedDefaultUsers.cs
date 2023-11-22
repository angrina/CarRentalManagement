using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(8677), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9007), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9012), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9178), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9180), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9182), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9183), new DateTime(2023, 11, 21, 15, 53, 31, 271, DateTimeKind.Local).AddTicks(9184) });
        }
    }
}
