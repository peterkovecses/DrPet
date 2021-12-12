using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DrPet.Data.Migrations
{
    public partial class SeedingWorkersPhotoPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 11, 1, 2, 13, 504, DateTimeKind.Local).AddTicks(5098), new DateTime(2021, 12, 10, 17, 2, 13, 500, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 12, 1, 2, 13, 504, DateTimeKind.Local).AddTicks(6320), new DateTime(2021, 12, 11, 17, 2, 13, 504, DateTimeKind.Local).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 13, 1, 2, 13, 504, DateTimeKind.Local).AddTicks(6332), new DateTime(2021, 12, 12, 17, 2, 13, 504, DateTimeKind.Local).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 14, 1, 2, 13, 504, DateTimeKind.Local).AddTicks(6341), new DateTime(2021, 12, 13, 17, 2, 13, 504, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoPath",
                value: "doctorImages/1.jpg");

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoPath",
                value: "doctorImages/2.jpg");

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoPath",
                value: "doctorImages/3.jpg");

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhotoPath",
                value: "doctorImages/4.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 10, 2, 16, 22, 619, DateTimeKind.Local).AddTicks(9619), new DateTime(2021, 12, 9, 18, 16, 22, 616, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 11, 2, 16, 22, 620, DateTimeKind.Local).AddTicks(791), new DateTime(2021, 12, 10, 18, 16, 22, 620, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 12, 2, 16, 22, 620, DateTimeKind.Local).AddTicks(801), new DateTime(2021, 12, 11, 18, 16, 22, 620, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 13, 2, 16, 22, 620, DateTimeKind.Local).AddTicks(810), new DateTime(2021, 12, 12, 18, 16, 22, 620, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoPath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhotoPath",
                value: null);
        }
    }
}
