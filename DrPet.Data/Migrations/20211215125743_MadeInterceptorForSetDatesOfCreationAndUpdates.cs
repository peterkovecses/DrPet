using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DrPet.Data.Migrations
{
    public partial class MadeInterceptorForSetDatesOfCreationAndUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 15, 21, 57, 41, 772, DateTimeKind.Local).AddTicks(8596), new DateTime(2021, 12, 15, 13, 57, 41, 769, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 16, 21, 57, 41, 772, DateTimeKind.Local).AddTicks(9999), new DateTime(2021, 12, 16, 13, 57, 41, 772, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 17, 21, 57, 41, 773, DateTimeKind.Local).AddTicks(10), new DateTime(2021, 12, 17, 13, 57, 41, 773, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 18, 21, 57, 41, 773, DateTimeKind.Local).AddTicks(18), new DateTime(2021, 12, 18, 13, 57, 41, 773, DateTimeKind.Local).AddTicks(14) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 15, 21, 10, 52, 572, DateTimeKind.Local).AddTicks(5240), new DateTime(2021, 12, 15, 13, 10, 52, 568, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 16, 21, 10, 52, 572, DateTimeKind.Local).AddTicks(6730), new DateTime(2021, 12, 16, 13, 10, 52, 572, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 17, 21, 10, 52, 572, DateTimeKind.Local).AddTicks(6743), new DateTime(2021, 12, 17, 13, 10, 52, 572, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 12, 18, 21, 10, 52, 572, DateTimeKind.Local).AddTicks(6753), new DateTime(2021, 12, 18, 13, 10, 52, 572, DateTimeKind.Local).AddTicks(6748) });
        }
    }
}
