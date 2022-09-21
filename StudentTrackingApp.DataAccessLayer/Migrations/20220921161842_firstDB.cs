using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentTracking.DataAccessLayer.Migrations
{
    public partial class firstDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AboutContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutImage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AdminSurname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AdminEmail = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AdminPassword = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AdminRole = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    BookPageCount = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassNAme = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactSubject = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactStatus = table.Column<bool>(type: "bit", nullable: false),
                    ContactMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "ExamTYTs",
                columns: table => new
                {
                    ExamTYTId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamTYTName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExamTYTDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TurkceDogru = table.Column<byte>(type: "tinyint", nullable: false),
                    TurkceYanlis = table.Column<byte>(type: "tinyint", nullable: false),
                    SosyalBilimlerDogru = table.Column<byte>(type: "tinyint", nullable: false),
                    SosyalBilimlerYanlis = table.Column<byte>(type: "tinyint", nullable: false),
                    MatematikDogru = table.Column<byte>(type: "tinyint", nullable: false),
                    MatematikYanlis = table.Column<byte>(type: "tinyint", nullable: false),
                    FenBilimleriDogru = table.Column<byte>(type: "tinyint", nullable: false),
                    FenBilimleriYanlis = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamTYTs", x => x.ExamTYTId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TeacherSurname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LessonId = table.Column<byte>(type: "tinyint", nullable: false),
                    TeacherEMail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentNumber = table.Column<int>(type: "int", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    StudentSurname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    StudentGender = table.Column<bool>(type: "bit", nullable: false),
                    StudentEMail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    StudentPassword = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    StudentStatus = table.Column<bool>(type: "bit", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookStudent",
                columns: table => new
                {
                    BooksBookId = table.Column<int>(type: "int", nullable: false),
                    StudentsStudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookStudent", x => new { x.BooksBookId, x.StudentsStudentId });
                    table.ForeignKey(
                        name: "FK_BookStudent_Books_BooksBookId",
                        column: x => x.BooksBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookStudent_Students_StudentsStudentId",
                        column: x => x.StudentsStudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluations",
                columns: table => new
                {
                    EvaluationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EvaluationTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EvaluationContent = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    EvaluationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EvaluationStatus = table.Column<bool>(type: "bit", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluations", x => x.EvaluationId);
                    table.ForeignKey(
                        name: "FK_Evaluations_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamTYTStudent",
                columns: table => new
                {
                    ExamTYTsExamTYTId = table.Column<int>(type: "int", nullable: false),
                    StudentsStudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamTYTStudent", x => new { x.ExamTYTsExamTYTId, x.StudentsStudentId });
                    table.ForeignKey(
                        name: "FK_ExamTYTStudent_ExamTYTs_ExamTYTsExamTYTId",
                        column: x => x.ExamTYTsExamTYTId,
                        principalTable: "ExamTYTs",
                        principalColumn: "ExamTYTId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamTYTStudent_Students_StudentsStudentId",
                        column: x => x.StudentsStudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    LessonId = table.Column<byte>(type: "tinyint", nullable: false),
                    LessonName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.LessonId);
                    table.ForeignKey(
                        name: "FK_Lessons_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    TodoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TodoFirst = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TodoFinish = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TodoTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TodoContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TodoStatus = table.Column<bool>(type: "bit", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.TodoId);
                    table.ForeignKey(
                        name: "FK_Todos_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionCount = table.Column<int>(type: "int", nullable: false),
                    QuestionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    LessonId = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Questions_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    LessonId1 = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                    table.ForeignKey(
                        name: "FK_Subjects_Lessons_LessonId1",
                        column: x => x.LessonId1,
                        principalTable: "Lessons",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookStudent_StudentsStudentId",
                table: "BookStudent",
                column: "StudentsStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluations_StudentId",
                table: "Evaluations",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamTYTStudent_StudentsStudentId",
                table: "ExamTYTStudent",
                column: "StudentsStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_StudentId",
                table: "Lessons",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_LessonId",
                table: "Questions",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_StudentId",
                table: "Questions",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeacherId",
                table: "Students",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_LessonId1",
                table: "Subjects",
                column: "LessonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Todos_StudentId",
                table: "Todos",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "BookStudent");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Evaluations");

            migrationBuilder.DropTable(
                name: "ExamTYTStudent");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Todos");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "ExamTYTs");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
