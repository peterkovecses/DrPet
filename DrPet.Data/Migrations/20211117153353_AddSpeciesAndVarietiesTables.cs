using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DrPet.Data.Migrations
{
    public partial class AddSpeciesAndVarietiesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Variety_VarietyId",
                table: "Pets");

            migrationBuilder.DropForeignKey(
                name: "FK_Variety_Species_SpeciesId",
                table: "Variety");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Variety",
                table: "Variety");

            migrationBuilder.RenameTable(
                name: "Variety",
                newName: "Varieties");

            migrationBuilder.RenameIndex(
                name: "IX_Variety_SpeciesId",
                table: "Varieties",
                newName: "IX_Varieties_SpeciesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Varieties",
                table: "Varieties",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Medicine",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "Name" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Probatbicol (350mg)" },
                    { 2, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Placebotinol (0mg)" }
                });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "LatinName", "Name" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Canis lupus familiaris", "Kutya" },
                    { 2, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felis catus", "Macska" }
                });

            migrationBuilder.InsertData(
                table: "TreatmentTypes",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "Name", "Price" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rutinvizsgálat (panasz nélkül)", 10000.0 },
                    { 2, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vizsgálat (akut panaszok)", 12000.0 },
                    { 3, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kontrollvizsgálat", 8000.0 },
                    { 4, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Műtét", 30000.0 },
                    { 5, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gyógyszer felírása", 2500.0 }
                });

            migrationBuilder.InsertData(
                table: "Varieties",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "Name", "SpeciesId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Puli", 1 },
                    { 2, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labrador", 1 },
                    { 3, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amerikai rövidszőrű", 2 },
                    { 4, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perzsa", 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Varieties_VarietyId",
                table: "Pets",
                column: "VarietyId",
                principalTable: "Varieties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Varieties_Species_SpeciesId",
                table: "Varieties",
                column: "SpeciesId",
                principalTable: "Species",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Varieties_VarietyId",
                table: "Pets");

            migrationBuilder.DropForeignKey(
                name: "FK_Varieties_Species_SpeciesId",
                table: "Varieties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Varieties",
                table: "Varieties");

            migrationBuilder.DeleteData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TreatmentTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TreatmentTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TreatmentTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TreatmentTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TreatmentTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Varieties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Varieties",
                newName: "Variety");

            migrationBuilder.RenameIndex(
                name: "IX_Varieties_SpeciesId",
                table: "Variety",
                newName: "IX_Variety_SpeciesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Variety",
                table: "Variety",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Variety_VarietyId",
                table: "Pets",
                column: "VarietyId",
                principalTable: "Variety",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Variety_Species_SpeciesId",
                table: "Variety",
                column: "SpeciesId",
                principalTable: "Species",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
