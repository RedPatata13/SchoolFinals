using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finals.Migrations
{
    /// <inheritdoc />
    public partial class AssignedCourseGrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignedCourseGradeId",
                table: "AssignedCourseRegistrations",
                type: "varchar(50)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AssignedCourseGrade",
                columns: table => new
                {
                    GradeId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AssignedCourseId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StudentId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegistrationId = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Grade = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateAssigned = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignedCourseGrade", x => x.GradeId);
                    table.ForeignKey(
                        name: "FK_AssignedCourseGrade_AssignedCourseRegistrations_Registration~",
                        column: x => x.RegistrationId,
                        principalTable: "AssignedCourseRegistrations",
                        principalColumn: "AssignedCourseRegistrationId");
                    table.ForeignKey(
                        name: "FK_AssignedCourseGrade_AssignedCourses_AssignedCourseId",
                        column: x => x.AssignedCourseId,
                        principalTable: "AssignedCourses",
                        principalColumn: "AssignedCourseModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssignedCourseGrade_StudentModels_StudentId",
                        column: x => x.StudentId,
                        principalTable: "StudentModels",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedCourseRegistrations_AssignedCourseGradeId",
                table: "AssignedCourseRegistrations",
                column: "AssignedCourseGradeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssignedCourseGrade_AssignedCourseId",
                table: "AssignedCourseGrade",
                column: "AssignedCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedCourseGrade_RegistrationId",
                table: "AssignedCourseGrade",
                column: "RegistrationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssignedCourseGrade_StudentId",
                table: "AssignedCourseGrade",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourseRegistrations_AssignedCourseGrade_AssignedCour~",
                table: "AssignedCourseRegistrations",
                column: "AssignedCourseGradeId",
                principalTable: "AssignedCourseGrade",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourseRegistrations_AssignedCourseGrade_AssignedCour~",
                table: "AssignedCourseRegistrations");

            migrationBuilder.DropTable(
                name: "AssignedCourseGrade");

            migrationBuilder.DropIndex(
                name: "IX_AssignedCourseRegistrations_AssignedCourseGradeId",
                table: "AssignedCourseRegistrations");

            migrationBuilder.DropColumn(
                name: "AssignedCourseGradeId",
                table: "AssignedCourseRegistrations");
        }
    }
}
