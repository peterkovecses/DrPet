using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DrPet.Data.Migrations
{
    public partial class EntityBaseClassToAbstractClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
