using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentTracking.DataAccessLayer.Migrations
{
    public partial class threemig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Lessons_LessonId1",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_LessonId1",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "LessonId1",
                table: "Subjects");

            migrationBuilder.AlterColumn<byte>(
                name: "LessonId",
                table: "Subjects",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_LessonId",
                table: "Subjects",
                column: "LessonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Lessons_LessonId",
                table: "Subjects",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "LessonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Lessons_LessonId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_LessonId",
                table: "Subjects");

            migrationBuilder.AlterColumn<int>(
                name: "LessonId",
                table: "Subjects",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AddColumn<byte>(
                name: "LessonId1",
                table: "Subjects",
                type: "tinyint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_LessonId1",
                table: "Subjects",
                column: "LessonId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Lessons_LessonId1",
                table: "Subjects",
                column: "LessonId1",
                principalTable: "Lessons",
                principalColumn: "LessonId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
