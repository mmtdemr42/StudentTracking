using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentTracking.DataAccessLayer.Migrations
{
    public partial class exam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "TurkceYanlis",
                table: "ExamTYTs",
                type: "real",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<float>(
                name: "TurkceDogru",
                table: "ExamTYTs",
                type: "real",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<float>(
                name: "SosyalBilimlerYanlis",
                table: "ExamTYTs",
                type: "real",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<float>(
                name: "SosyalBilimlerDogru",
                table: "ExamTYTs",
                type: "real",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<float>(
                name: "MatematikYanlis",
                table: "ExamTYTs",
                type: "real",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<float>(
                name: "MatematikDogru",
                table: "ExamTYTs",
                type: "real",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<float>(
                name: "FenBilimleriYanlis",
                table: "ExamTYTs",
                type: "real",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<float>(
                name: "FenBilimleriDogru",
                table: "ExamTYTs",
                type: "real",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExamTYTDate",
                table: "ExamTYTs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "TurkceYanlis",
                table: "ExamTYTs",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<byte>(
                name: "TurkceDogru",
                table: "ExamTYTs",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<byte>(
                name: "SosyalBilimlerYanlis",
                table: "ExamTYTs",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<byte>(
                name: "SosyalBilimlerDogru",
                table: "ExamTYTs",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<byte>(
                name: "MatematikYanlis",
                table: "ExamTYTs",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<byte>(
                name: "MatematikDogru",
                table: "ExamTYTs",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<byte>(
                name: "FenBilimleriYanlis",
                table: "ExamTYTs",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<byte>(
                name: "FenBilimleriDogru",
                table: "ExamTYTs",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExamTYTDate",
                table: "ExamTYTs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
