using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finals.Migrations
{
    /// <inheritdoc />
    public partial class AssignedCourse_SemesterAndStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SemesterId",
                table: "AssignedCourses",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "AssignedCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AssignedCourses_SemesterId",
                table: "AssignedCourses",
                column: "SemesterId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourses_Semesters_SemesterId",
                table: "AssignedCourses",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "SemesterId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourses_Semesters_SemesterId",
                table: "AssignedCourses");

            migrationBuilder.DropIndex(
                name: "IX_AssignedCourses_SemesterId",
                table: "AssignedCourses");

            migrationBuilder.DropColumn(
                name: "SemesterId",
                table: "AssignedCourses");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AssignedCourses");
        }
    }
}
