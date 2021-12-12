using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DrPet.Data.Migrations
{
    public partial class AddPhotoPathPropertyToWorker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Workers",
                type: "nvarchar(max)",
                nullable: true);

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
                column: "Name",
                value: "Dr. Szabó Ildikó");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Workers");

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 11, 28, 20, 13, 48, 388, DateTimeKind.Local).AddTicks(4866), new DateTime(2021, 11, 28, 12, 13, 48, 385, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 11, 29, 20, 13, 48, 388, DateTimeKind.Local).AddTicks(6012), new DateTime(2021, 11, 29, 12, 13, 48, 388, DateTimeKind.Local).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 11, 30, 20, 13, 48, 388, DateTimeKind.Local).AddTicks(6022), new DateTime(2021, 11, 30, 12, 13, 48, 388, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 1, 20, 13, 48, 388, DateTimeKind.Local).AddTicks(6031), new DateTime(2021, 12, 1, 12, 13, 48, 388, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Dr. Szabó ildikó");
        }
    }
}
