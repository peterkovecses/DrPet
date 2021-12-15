using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DrPet.Data.Migrations
{
    public partial class GenerateMoreConsultings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 10, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 10, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 10, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndOfConsulting", "StartOfConsulting" },
                values: new object[] { new DateTime(2021, 10, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 799, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 530, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 531, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 532, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 533, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 31, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 31, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 534, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 535, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 536, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 537, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 538, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 529, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 539, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 541, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 542, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 543, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 544, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 545, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 546, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 547, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 548, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 549, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 540, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 528, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 527, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 526, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 505, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 506, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 507, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 508, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 509, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 510, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 511, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 512, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 513, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 514, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 515, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 516, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 517, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 518, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 519, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 520, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 521, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 522, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 523, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 524, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 525, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 550, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 551, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 552, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 553, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 579, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 580, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 581, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 582, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 583, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 584, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 585, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 586, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 587, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 588, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 589, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 590, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 591, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 592, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 593, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 594, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 31, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 595, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 596, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 597, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 598, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 599, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 578, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 504, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 577, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 575, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 554, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 555, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 556, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 557, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 558, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 559, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 560, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 561, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 562, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 563, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 4, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 564, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 565, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 566, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 567, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 568, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 569, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 570, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 571, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 572, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 573, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 574, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 576, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 5, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 600, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 503, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 3, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 501, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 431, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 432, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 433, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 434, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 435, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 436, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 437, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 438, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 439, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 430, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 440, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 442, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 443, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 31, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 31, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 444, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 445, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 446, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 447, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 448, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 449, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 450, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 441, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 429, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 428, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 427, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 406, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 407, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 408, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 409, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 410, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 411, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 412, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 413, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 414, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 415, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 416, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 417, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 418, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 419, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 420, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 421, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 422, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 423, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 424, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 425, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 426, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 12, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 451, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 452, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 453, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 454, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 480, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 481, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 482, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 483, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 484, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 485, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 486, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 487, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 488, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 489, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 490, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 491, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 492, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 493, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 494, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 495, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 496, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 497, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 498, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 499, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 500, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 479, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 502, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 478, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 476, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 455, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 456, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 457, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 458, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 459, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 460, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 461, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 462, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 463, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 464, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 465, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 466, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 467, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 468, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 469, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 470, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 471, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 472, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 473, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 474, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 31, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 1, 31, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 475, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 477, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 2, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 601, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 602, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 603, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 729, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 730, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 731, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 732, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 733, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 734, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 735, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 736, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 737, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 728, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 738, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 740, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 741, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 742, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 743, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 744, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 745, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 746, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 747, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 31, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 31, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 748, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 739, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 727, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 726, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 725, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 704, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 705, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 706, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 707, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 708, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 709, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 710, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 711, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 712, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 713, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 714, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 715, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 716, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 717, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 718, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 719, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 720, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 721, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 722, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 723, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 724, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 10, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 749, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 750, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 751, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 752, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 778, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 779, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 780, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 781, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 782, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 783, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 784, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 785, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 786, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 787, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 788, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 789, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 790, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 791, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 792, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 793, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 794, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 795, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 796, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 797, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 798, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 777, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 703, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 776, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 774, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 753, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 754, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 755, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 756, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 757, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 758, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 759, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 760, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 761, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 762, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 763, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 764, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 765, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 766, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 767, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 768, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 769, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 770, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 771, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 772, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 773, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 775, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 11, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 702, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 701, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 700, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 629, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 630, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 631, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 632, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 633, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 634, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 635, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 636, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 637, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 638, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 639, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 640, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 641, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 642, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 643, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 644, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 645, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 646, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 647, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 648, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 649, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 628, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 650, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 627, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 625, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 405, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 605, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 606, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 607, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 608, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 609, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 610, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 611, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 612, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 613, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 614, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 615, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 616, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 617, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 618, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 619, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 620, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 621, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 622, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 623, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 624, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 626, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 800, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 12, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 651, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 653, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 679, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 680, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 681, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 682, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 683, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 684, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 685, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 686, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 31, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 31, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 687, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 688, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 689, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 690, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 691, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 692, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 693, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 694, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 695, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 696, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 697, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 698, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 699, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 9, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 678, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 652, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 677, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 675, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 654, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 655, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 31, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 7, 31, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 656, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 657, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 658, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 659, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 660, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 661, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 662, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 663, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 664, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 665, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 666, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 667, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 668, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 669, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 670, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 671, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 672, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 673, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 674, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 676, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 8, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 604, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2023, 6, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 404, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 402, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 131, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 132, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 133, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 134, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 135, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 136, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 137, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 138, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 139, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 140, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 141, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 142, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 143, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 144, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 145, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 146, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 147, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 148, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 149, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 150, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 151, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 130, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 152, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 129, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 127, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 106, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 107, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 108, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 109, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 31, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 31, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 110, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 111, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 112, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 113, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 114, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 115, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 116, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 117, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 118, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 119, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 120, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 121, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 122, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 123, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 124, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 125, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 126, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 128, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 2, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 105, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 153, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 155, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 181, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 182, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 183, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 184, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 185, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 186, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 187, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 188, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 189, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 190, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 191, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 192, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 193, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 194, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 195, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 196, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 197, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 198, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 199, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 200, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 201, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 180, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 154, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 179, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 177, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 156, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 157, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 158, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 159, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 160, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 161, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 162, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 163, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 164, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 165, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 166, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 167, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 168, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 31, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 3, 31, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 169, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 170, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 171, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 172, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 173, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 174, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 175, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 176, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 178, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 4, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 202, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 104, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 102, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 31, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 32, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 33, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 34, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 35, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 36, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 37, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 38, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 39, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 40, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 41, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 42, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 43, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 44, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 45, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 46, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 47, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 48, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 49, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 50, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 51, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 30, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 52, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 29, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 27, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 6, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 7, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 8, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 9, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 10, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 11, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 12, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 13, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 14, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 15, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 16, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 17, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 31, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 31, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 18, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 19, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 20, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 21, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 22, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 23, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 24, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 25, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 26, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 28, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 11, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 103, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 53, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 55, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 81, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 82, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 83, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 84, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 85, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 86, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 87, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 88, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 89, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 90, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 91, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 92, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 93, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 94, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 95, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 96, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 97, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 98, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 99, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 100, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 101, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 80, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 54, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 79, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 1, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 77, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 56, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 57, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 58, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 59, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 60, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 61, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 62, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 63, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 64, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 65, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 66, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 67, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 68, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 69, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 70, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 71, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 72, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 73, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 74, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 75, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 76, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 78, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 31, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 12, 31, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 403, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 203, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 205, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 331, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 332, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 333, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 334, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 335, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 336, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 337, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 338, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 339, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 340, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 341, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 342, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 343, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 344, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 345, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 346, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 347, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 348, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 349, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 350, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 351, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 330, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 352, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 329, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 327, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 306, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 307, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 308, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 309, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 310, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 311, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 312, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 313, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 314, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 315, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 316, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 317, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 318, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 319, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 320, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 321, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 31, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 31, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 322, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 323, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 324, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 325, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 326, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 328, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 9, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 305, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 353, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 355, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 381, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 382, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 31, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 31, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 383, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 384, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 385, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 386, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 387, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 388, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 389, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 390, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 391, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 392, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 393, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 394, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 395, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 396, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 397, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 398, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 399, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 400, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 401, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 11, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 380, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 354, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 379, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 377, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 356, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 357, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 358, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 359, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 360, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 361, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 362, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 363, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 364, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 365, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 366, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 367, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 368, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 369, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 370, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 371, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 372, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 373, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 374, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 375, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 376, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 378, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 10, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 204, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 304, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 302, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 231, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 232, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 233, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 234, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 235, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 236, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 237, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 238, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 239, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 240, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 241, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 242, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 243, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 244, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 245, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 246, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 247, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 248, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 249, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 250, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 251, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 230, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 252, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 229, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 31, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 31, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 227, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 206, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 207, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 208, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 209, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 210, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 211, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 212, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 213, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 214, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 215, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 216, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 217, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 218, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 219, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 220, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 221, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 222, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 223, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 224, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 225, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 226, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 228, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 5, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 303, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 253, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 255, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 281, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 22, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 22, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 282, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 23, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 23, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 283, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 24, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 24, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 284, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 285, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 26, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 26, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 286, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 287, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 288, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 289, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 290, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 31, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 31, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 291, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 292, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 293, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 294, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 295, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 296, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 297, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 298, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 299, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 300, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 301, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 8, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 280, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 21, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 21, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 254, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 25, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 25, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 279, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 20, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 20, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 277, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 18, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 18, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 256, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 27, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 27, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 257, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 28, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 28, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 258, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 29, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 29, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 259, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 30, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 6, 30, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 260, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 1, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 1, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 261, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 2, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 2, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 262, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 3, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 3, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 263, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 4, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 4, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 264, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 5, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 5, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 265, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 6, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 6, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 266, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 7, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 7, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 267, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 8, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 8, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 268, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 9, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 9, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 269, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 10, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 10, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 270, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 11, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 11, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 271, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 12, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 12, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 272, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 13, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 13, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 },
                    { 273, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 14, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 14, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 },
                    { 274, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 15, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 15, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 },
                    { 275, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 16, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 16, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 3 },
                    { 276, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 17, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 17, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 4 }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[] { 278, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2022, 7, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 2 });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[] { 5, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 19, 22, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), new DateTime(2021, 10, 19, 14, 35, 0, 268, DateTimeKind.Local).AddTicks(7675), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 800);

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
    }
}
