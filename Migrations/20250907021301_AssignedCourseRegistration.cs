using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finals.Migrations
{
    /// <inheritdoc />
    public partial class AssignedCourseRegistration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssignedCourseRegistrations",
                columns: table => new
                {
                    AssignedCourseRegistrationId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AssignedCourseId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegistrationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignedCourseRegistrations", x => x.AssignedCourseRegistrationId);
                    table.ForeignKey(
                        name: "FK_AssignedCourseRegistrations_AssignedCourses_AssignedCourseId",
                        column: x => x.AssignedCourseId,
                        principalTable: "AssignedCourses",
                        principalColumn: "AssignedCourseModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssignedCourseRegistrations_StudentModels_UserId",
                        column: x => x.UserId,
                        principalTable: "StudentModels",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedCourseRegistrations_AssignedCourseId",
                table: "AssignedCourseRegistrations",
                column: "AssignedCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedCourseRegistrations_UserId",
                table: "AssignedCourseRegistrations",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignedCourseRegistrations");
        }
    }
}
