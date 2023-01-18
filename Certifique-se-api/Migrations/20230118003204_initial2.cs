using Microsoft.EntityFrameworkCore.Migrations;

namespace Certifique_se_api.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentFuntion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstructorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseNameCourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.InstructorId);
                    table.ForeignKey(
                        name: "FK_Instructors_Courses_CourseNameCourseId",
                        column: x => x.CourseNameCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCnpj = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customers_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PresenceLists",
                columns: table => new
                {
                    PresenceListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseNameCourseId = table.Column<int>(type: "int", nullable: true),
                    CustomerNameCustomerID = table.Column<int>(type: "int", nullable: true),
                    CustomerCnpjCustomerID = table.Column<int>(type: "int", nullable: true),
                    InstructorNameInstructorId = table.Column<int>(type: "int", nullable: true),
                    StudentNameStudentId = table.Column<int>(type: "int", nullable: true),
                    StudentFuntionStudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresenceLists", x => x.PresenceListId);
                    table.ForeignKey(
                        name: "FK_PresenceLists_Courses_CourseNameCourseId",
                        column: x => x.CourseNameCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PresenceLists_Customers_CustomerCnpjCustomerID",
                        column: x => x.CustomerCnpjCustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PresenceLists_Customers_CustomerNameCustomerID",
                        column: x => x.CustomerNameCustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PresenceLists_Instructors_InstructorNameInstructorId",
                        column: x => x.InstructorNameInstructorId,
                        principalTable: "Instructors",
                        principalColumn: "InstructorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PresenceLists_Students_StudentFuntionStudentId",
                        column: x => x.StudentFuntionStudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PresenceLists_Students_StudentNameStudentId",
                        column: x => x.StudentNameStudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_StudentId",
                table: "Customers",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_CourseNameCourseId",
                table: "Instructors",
                column: "CourseNameCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_PresenceLists_CourseNameCourseId",
                table: "PresenceLists",
                column: "CourseNameCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_PresenceLists_CustomerCnpjCustomerID",
                table: "PresenceLists",
                column: "CustomerCnpjCustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_PresenceLists_CustomerNameCustomerID",
                table: "PresenceLists",
                column: "CustomerNameCustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_PresenceLists_InstructorNameInstructorId",
                table: "PresenceLists",
                column: "InstructorNameInstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_PresenceLists_StudentFuntionStudentId",
                table: "PresenceLists",
                column: "StudentFuntionStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_PresenceLists_StudentNameStudentId",
                table: "PresenceLists",
                column: "StudentNameStudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PresenceLists");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
