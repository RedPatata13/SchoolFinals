using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finals.Migrations
{
    /// <inheritdoc />
    public partial class AssignedCoruseTerm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourseGrade_AssignedCourseRegistrations_Registration~",
                table: "AssignedCourseGrade");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourseGrade_AssignedCourses_AssignedCourseId",
                table: "AssignedCourseGrade");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourseGrade_StudentModels_StudentId",
                table: "AssignedCourseGrade");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourseRegistrations_AssignedCourseGrade_AssignedCour~",
                table: "AssignedCourseRegistrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssignedCourseGrade",
                table: "AssignedCourseGrade");

            migrationBuilder.RenameTable(
                name: "AssignedCourseGrade",
                newName: "AssignedCourseGrades");

            migrationBuilder.RenameIndex(
                name: "IX_AssignedCourseGrade_StudentId",
                table: "AssignedCourseGrades",
                newName: "IX_AssignedCourseGrades_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_AssignedCourseGrade_RegistrationId",
                table: "AssignedCourseGrades",
                newName: "IX_AssignedCourseGrades_RegistrationId");

            migrationBuilder.RenameIndex(
                name: "IX_AssignedCourseGrade_AssignedCourseId",
                table: "AssignedCourseGrades",
                newName: "IX_AssignedCourseGrades_AssignedCourseId");

            migrationBuilder.AddColumn<string>(
                name: "TermId",
                table: "AssignedCourseRegistrations",
                type: "varchar(30)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssignedCourseGrades",
                table: "AssignedCourseGrades",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedCourseRegistrations_TermId",
                table: "AssignedCourseRegistrations",
                column: "TermId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourseGrades_AssignedCourseRegistrations_Registratio~",
                table: "AssignedCourseGrades",
                column: "RegistrationId",
                principalTable: "AssignedCourseRegistrations",
                principalColumn: "AssignedCourseRegistrationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourseGrades_AssignedCourses_AssignedCourseId",
                table: "AssignedCourseGrades",
                column: "AssignedCourseId",
                principalTable: "AssignedCourses",
                principalColumn: "AssignedCourseModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourseGrades_StudentModels_StudentId",
                table: "AssignedCourseGrades",
                column: "StudentId",
                principalTable: "StudentModels",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourseRegistrations_AssignedCourseGrades_AssignedCou~",
                table: "AssignedCourseRegistrations",
                column: "AssignedCourseGradeId",
                principalTable: "AssignedCourseGrades",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourseRegistrations_Terms_TermId",
                table: "AssignedCourseRegistrations",
                column: "TermId",
                principalTable: "Terms",
                principalColumn: "TermId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourseGrades_AssignedCourseRegistrations_Registratio~",
                table: "AssignedCourseGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourseGrades_AssignedCourses_AssignedCourseId",
                table: "AssignedCourseGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourseGrades_StudentModels_StudentId",
                table: "AssignedCourseGrades");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourseRegistrations_AssignedCourseGrades_AssignedCou~",
                table: "AssignedCourseRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourseRegistrations_Terms_TermId",
                table: "AssignedCourseRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_AssignedCourseRegistrations_TermId",
                table: "AssignedCourseRegistrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssignedCourseGrades",
                table: "AssignedCourseGrades");

            migrationBuilder.DropColumn(
                name: "TermId",
                table: "AssignedCourseRegistrations");

            migrationBuilder.RenameTable(
                name: "AssignedCourseGrades",
                newName: "AssignedCourseGrade");

            migrationBuilder.RenameIndex(
                name: "IX_AssignedCourseGrades_StudentId",
                table: "AssignedCourseGrade",
                newName: "IX_AssignedCourseGrade_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_AssignedCourseGrades_RegistrationId",
                table: "AssignedCourseGrade",
                newName: "IX_AssignedCourseGrade_RegistrationId");

            migrationBuilder.RenameIndex(
                name: "IX_AssignedCourseGrades_AssignedCourseId",
                table: "AssignedCourseGrade",
                newName: "IX_AssignedCourseGrade_AssignedCourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssignedCourseGrade",
                table: "AssignedCourseGrade",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourseGrade_AssignedCourseRegistrations_Registration~",
                table: "AssignedCourseGrade",
                column: "RegistrationId",
                principalTable: "AssignedCourseRegistrations",
                principalColumn: "AssignedCourseRegistrationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourseGrade_AssignedCourses_AssignedCourseId",
                table: "AssignedCourseGrade",
                column: "AssignedCourseId",
                principalTable: "AssignedCourses",
                principalColumn: "AssignedCourseModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourseGrade_StudentModels_StudentId",
                table: "AssignedCourseGrade",
                column: "StudentId",
                principalTable: "StudentModels",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourseRegistrations_AssignedCourseGrade_AssignedCour~",
                table: "AssignedCourseRegistrations",
                column: "AssignedCourseGradeId",
                principalTable: "AssignedCourseGrade",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
