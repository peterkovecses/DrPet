using Microsoft.EntityFrameworkCore.Migrations;

namespace DrPet.Data.Migrations
{
    public partial class RenameTableMedicineToMedicines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_Medicine_MedicineId",
                table: "Treatments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicine",
                table: "Medicine");

            migrationBuilder.RenameTable(
                name: "Medicine",
                newName: "Medicines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicines",
                table: "Medicines",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_Medicines_MedicineId",
                table: "Treatments",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_Medicines_MedicineId",
                table: "Treatments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicines",
                table: "Medicines");

            migrationBuilder.RenameTable(
                name: "Medicines",
                newName: "Medicine");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicine",
                table: "Medicine",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_Medicine_MedicineId",
                table: "Treatments",
                column: "MedicineId",
                principalTable: "Medicine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
