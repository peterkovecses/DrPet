using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DrPet.Data.Migrations
{
    public partial class UpdateTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Placebotinol (50mg)");

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Birthdate", "Comment", "DateOfCreation", "DateOfUpdate", "Location", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1995, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Győr", "Gazdi Dezső" },
                    { 2, new DateTime(1995, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Győrújbarát", "Béka Bandi" }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Birthdate", "Comment", "DateOfCreation", "DateOfUpdate", "Name", "Status", "VarietyId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Versenydíjas (2019)", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blöki", 0, 1 },
                    { 2, new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pimpedli", 0, 1 },
                    { 3, new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Banán", 0, 2 },
                    { 4, new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ms. Purry", 0, 3 }
                });

            migrationBuilder.InsertData(
                table: "PetOwnerships",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "OwnerId", "PetId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 3, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 4, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PetOwnerships",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PetOwnerships",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PetOwnerships",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PetOwnerships",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Placebotinol (10mg)");
        }
    }
}
