using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finals.Migrations
{
    /// <inheritdoc />
    public partial class TeacherCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourses_UserModels_TeacherId",
                table: "AssignedCourses");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourses_TeacherModels_TeacherId",
                table: "AssignedCourses",
                column: "TeacherId",
                principalTable: "TeacherModels",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourses_TeacherModels_TeacherId",
                table: "AssignedCourses");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourses_UserModels_TeacherId",
                table: "AssignedCourses",
                column: "TeacherId",
                principalTable: "UserModels",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
