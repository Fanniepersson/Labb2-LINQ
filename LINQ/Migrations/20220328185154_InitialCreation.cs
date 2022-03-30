using Microsoft.EntityFrameworkCore.Migrations;

namespace LINQ.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    classID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    className = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.classID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    teacherID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(nullable: false),
                    lastName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.teacherID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    studentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(nullable: false),
                    lastName = table.Column<string>(nullable: false),
                    classID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.studentID);
                    table.ForeignKey(
                        name: "FK_Students_Classes_classID",
                        column: x => x.classID,
                        principalTable: "Classes",
                        principalColumn: "classID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolSubjects",
                columns: table => new
                {
                    subjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subjectName = table.Column<string>(nullable: false),
                    teacherID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolSubjects", x => x.subjectID);
                    table.ForeignKey(
                        name: "FK_SchoolSubjects_Teachers_teacherID",
                        column: x => x.teacherID,
                        principalTable: "Teachers",
                        principalColumn: "teacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubjects",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentID = table.Column<int>(nullable: false),
                    SchoolSubjectssubjectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubjects", x => x.id);
                    table.ForeignKey(
                        name: "FK_StudentSubjects_SchoolSubjects_SchoolSubjectssubjectID",
                        column: x => x.SchoolSubjectssubjectID,
                        principalTable: "SchoolSubjects",
                        principalColumn: "subjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubjects_Students_studentID",
                        column: x => x.studentID,
                        principalTable: "Students",
                        principalColumn: "studentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SchoolSubjects_teacherID",
                table: "SchoolSubjects",
                column: "teacherID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_classID",
                table: "Students",
                column: "classID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_SchoolSubjectssubjectID",
                table: "StudentSubjects",
                column: "SchoolSubjectssubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_studentID",
                table: "StudentSubjects",
                column: "studentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentSubjects");

            migrationBuilder.DropTable(
                name: "SchoolSubjects");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
