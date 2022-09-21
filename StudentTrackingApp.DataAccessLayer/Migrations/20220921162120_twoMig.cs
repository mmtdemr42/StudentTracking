using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentTracking.DataAccessLayer.Migrations
{
    public partial class twoMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Evaluations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_TeacherId",
                table: "Evaluations",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Teachers_TeacherId",
                table: "Evaluations",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Teachers_TeacherId",
                table: "Evaluations");

            migrationBuilder.DropIndex(
                name: "IX_Evaluations_TeacherId",
                table: "Evaluations");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Evaluations");
        }
    }
}
