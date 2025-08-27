using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finals.Migrations
{
    /// <inheritdoc />
    public partial class ClassSectionDefaultCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassSectionDefaultCourses",
                columns: table => new
                {
                    ClassSectionModelSectionID = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefaultCoursesCourseId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSectionDefaultCourses", x => new { x.ClassSectionModelSectionID, x.DefaultCoursesCourseId });
                    table.ForeignKey(
                        name: "FK_ClassSectionDefaultCourses_ClassSections_ClassSectionModelSe~",
                        column: x => x.ClassSectionModelSectionID,
                        principalTable: "ClassSections",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSectionDefaultCourses_Courses_DefaultCoursesCourseId",
                        column: x => x.DefaultCoursesCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSectionDefaultCourses_DefaultCoursesCourseId",
                table: "ClassSectionDefaultCourses",
                column: "DefaultCoursesCourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassSectionDefaultCourses");
        }
    }
}
