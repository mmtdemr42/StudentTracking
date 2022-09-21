using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentTracking.DataAccessLayer.Migrations
{
    public partial class twoMigg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClassNAme",
                table: "Classes",
                newName: "ClassName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClassName",
                table: "Classes",
                newName: "ClassNAme");
        }
    }
}
