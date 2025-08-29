using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finals.Migrations
{
    /// <inheritdoc />
    public partial class TermData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourses_Semesters_SemesterId",
                table: "AssignedCourses");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.AddColumn<string>(
                name: "TermId",
                table: "AssignedCourses",
                type: "varchar(50)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SchoolYearRegistrations",
                columns: table => new
                {
                    SYRegistrationId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SchoolYearId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegistrationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolYearRegistrations", x => x.SYRegistrationId);
                    table.ForeignKey(
                        name: "FK_SchoolYearRegistrations_SchoolYearModels_SchoolYearId",
                        column: x => x.SchoolYearId,
                        principalTable: "SchoolYearModels",
                        principalColumn: "SchoolYearId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolYearRegistrations_StudentModels_UserId",
                        column: x => x.UserId,
                        principalTable: "StudentModels",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    TermId = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TermName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DateStart = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DateEnd = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 2),
                    SchoolYearId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StandardTermId = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TermType = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.TermId);
                    table.ForeignKey(
                        name: "FK_Terms_SchoolYearModels_SchoolYearId",
                        column: x => x.SchoolYearId,
                        principalTable: "SchoolYearModels",
                        principalColumn: "SchoolYearId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Terms_Terms_StandardTermId",
                        column: x => x.StandardTermId,
                        principalTable: "Terms",
                        principalColumn: "TermId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClassSectionTermDatas",
                columns: table => new
                {
                    ClassSectionTermDataId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClassSectionId = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TermId = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SchoolYearId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSectionTermDatas", x => x.ClassSectionTermDataId);
                    table.ForeignKey(
                        name: "FK_ClassSectionTermDatas_ClassSections_ClassSectionId",
                        column: x => x.ClassSectionId,
                        principalTable: "ClassSections",
                        principalColumn: "SectionID");
                    table.ForeignKey(
                        name: "FK_ClassSectionTermDatas_SchoolYearModels_SchoolYearId",
                        column: x => x.SchoolYearId,
                        principalTable: "SchoolYearModels",
                        principalColumn: "SchoolYearId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSectionTermDatas_Terms_TermId",
                        column: x => x.TermId,
                        principalTable: "Terms",
                        principalColumn: "TermId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClassSectionRegistration",
                columns: table => new
                {
                    ClassSectionRegistrationId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClassSectionId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StudentID = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegistrationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ClassSectionTermDataModelClassSectionTermDataId = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSectionRegistration", x => x.ClassSectionRegistrationId);
                    table.ForeignKey(
                        name: "FK_ClassSectionRegistration_ClassSectionTermDatas_ClassSectionT~",
                        column: x => x.ClassSectionTermDataModelClassSectionTermDataId,
                        principalTable: "ClassSectionTermDatas",
                        principalColumn: "ClassSectionTermDataId");
                    table.ForeignKey(
                        name: "FK_ClassSectionRegistration_ClassSections_ClassSectionId",
                        column: x => x.ClassSectionId,
                        principalTable: "ClassSections",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSectionRegistration_StudentModels_StudentID",
                        column: x => x.StudentID,
                        principalTable: "StudentModels",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedCourses_TermId",
                table: "AssignedCourses",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSectionRegistration_ClassSectionId",
                table: "ClassSectionRegistration",
                column: "ClassSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSectionRegistration_ClassSectionTermDataModelClassSecti~",
                table: "ClassSectionRegistration",
                column: "ClassSectionTermDataModelClassSectionTermDataId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSectionRegistration_StudentID",
                table: "ClassSectionRegistration",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSectionTermDatas_ClassSectionId",
                table: "ClassSectionTermDatas",
                column: "ClassSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSectionTermDatas_SchoolYearId",
                table: "ClassSectionTermDatas",
                column: "SchoolYearId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSectionTermDatas_TermId",
                table: "ClassSectionTermDatas",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolYearRegistrations_SchoolYearId",
                table: "SchoolYearRegistrations",
                column: "SchoolYearId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolYearRegistrations_UserId",
                table: "SchoolYearRegistrations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Terms_SchoolYearId",
                table: "Terms",
                column: "SchoolYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Terms_StandardTermId",
                table: "Terms",
                column: "StandardTermId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourses_ClassSectionTermDatas_TermId",
                table: "AssignedCourses",
                column: "TermId",
                principalTable: "ClassSectionTermDatas",
                principalColumn: "ClassSectionTermDataId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourses_Terms_SemesterId",
                table: "AssignedCourses",
                column: "SemesterId",
                principalTable: "Terms",
                principalColumn: "TermId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourses_ClassSectionTermDatas_TermId",
                table: "AssignedCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_AssignedCourses_Terms_SemesterId",
                table: "AssignedCourses");

            migrationBuilder.DropTable(
                name: "ClassSectionRegistration");

            migrationBuilder.DropTable(
                name: "SchoolYearRegistrations");

            migrationBuilder.DropTable(
                name: "ClassSectionTermDatas");

            migrationBuilder.DropTable(
                name: "Terms");

            migrationBuilder.DropIndex(
                name: "IX_AssignedCourses_TermId",
                table: "AssignedCourses");

            migrationBuilder.DropColumn(
                name: "TermId",
                table: "AssignedCourses");

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    SemesterId = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SchoolYearId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StandardSemesterId = table.Column<string>(type: "varchar(30)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DateEnd = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DateStart = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    SemesterName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.SemesterId);
                    table.ForeignKey(
                        name: "FK_Semesters_SchoolYearModels_SchoolYearId",
                        column: x => x.SchoolYearId,
                        principalTable: "SchoolYearModels",
                        principalColumn: "SchoolYearId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Semesters_Semesters_StandardSemesterId",
                        column: x => x.StandardSemesterId,
                        principalTable: "Semesters",
                        principalColumn: "SemesterId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Semesters_SchoolYearId",
                table: "Semesters",
                column: "SchoolYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Semesters_StandardSemesterId",
                table: "Semesters",
                column: "StandardSemesterId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedCourses_Semesters_SemesterId",
                table: "AssignedCourses",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "SemesterId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
