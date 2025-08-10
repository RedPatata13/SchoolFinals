using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finals.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedAssignedCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssignedCourses",
                columns: table => new
                {
                    AssignedCourseModelId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TeacherId = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AssignedId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateAssigned = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    SectionId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignedCourses", x => x.AssignedCourseModelId);
                    table.ForeignKey(
                        name: "FK_AssignedCourses_ClassSections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "ClassSections",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssignedCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssignedCourses_UserModels_AssignedId",
                        column: x => x.AssignedId,
                        principalTable: "UserModels",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssignedCourses_UserModels_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "UserModels",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    VenueId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    AssignedCourseModelId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CourseModel_AssignedAssignedCourseModelId = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.VenueId);
                    table.ForeignKey(
                        name: "FK_Venues_AssignedCourses_AssignedCourseModelId",
                        column: x => x.AssignedCourseModelId,
                        principalTable: "AssignedCourses",
                        principalColumn: "AssignedCourseModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Venues_AssignedCourses_CourseModel_AssignedAssignedCourseMod~",
                        column: x => x.CourseModel_AssignedAssignedCourseModelId,
                        principalTable: "AssignedCourses",
                        principalColumn: "AssignedCourseModelId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedCourses_AssignedId",
                table: "AssignedCourses",
                column: "AssignedId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedCourses_CourseId",
                table: "AssignedCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedCourses_SectionId",
                table: "AssignedCourses",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedCourses_TeacherId",
                table: "AssignedCourses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Venues_AssignedCourseModelId",
                table: "Venues",
                column: "AssignedCourseModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Venues_CourseModel_AssignedAssignedCourseModelId",
                table: "Venues",
                column: "CourseModel_AssignedAssignedCourseModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venues");

            migrationBuilder.DropTable(
                name: "AssignedCourses");
        }
    }
}
