using Microsoft.EntityFrameworkCore.Migrations;

namespace DrPet.Data.Migrations
{
    public partial class RenameAppUserWorkersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUserWorker_AppUsers_AppUserId",
                table: "AppUserWorker");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUserWorker_Workers_WorkerId",
                table: "AppUserWorker");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserWorker",
                table: "AppUserWorker");

            migrationBuilder.RenameTable(
                name: "AppUserWorker",
                newName: "AppUserWorkers");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserWorker_WorkerId",
                table: "AppUserWorkers",
                newName: "IX_AppUserWorkers_WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserWorker_AppUserId_WorkerId",
                table: "AppUserWorkers",
                newName: "IX_AppUserWorkers_AppUserId_WorkerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserWorkers",
                table: "AppUserWorkers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserWorkers_AppUsers_AppUserId",
                table: "AppUserWorkers",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserWorkers_Workers_WorkerId",
                table: "AppUserWorkers",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUserWorkers_AppUsers_AppUserId",
                table: "AppUserWorkers");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUserWorkers_Workers_WorkerId",
                table: "AppUserWorkers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserWorkers",
                table: "AppUserWorkers");

            migrationBuilder.RenameTable(
                name: "AppUserWorkers",
                newName: "AppUserWorker");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserWorkers_WorkerId",
                table: "AppUserWorker",
                newName: "IX_AppUserWorker_WorkerId");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserWorkers_AppUserId_WorkerId",
                table: "AppUserWorker",
                newName: "IX_AppUserWorker_AppUserId_WorkerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserWorker",
                table: "AppUserWorker",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserWorker_AppUsers_AppUserId",
                table: "AppUserWorker",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserWorker_Workers_WorkerId",
                table: "AppUserWorker",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
