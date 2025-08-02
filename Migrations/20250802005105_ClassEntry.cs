using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finals.Migrations
{
    /// <inheritdoc />
    public partial class ClassEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YearLevel",
                table: "ClassSections",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ClassBatches",
                columns: table => new
                {
                    BatchId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BatchName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateStart = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DateEnd = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    ClassSectionId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassBatches", x => x.BatchId);
                    table.ForeignKey(
                        name: "FK_ClassBatches_ClassSections_ClassSectionId",
                        column: x => x.ClassSectionId,
                        principalTable: "ClassSections",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClassEntries",
                columns: table => new
                {
                    EntryId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EntryDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    ClassSectionId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BatchId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StudentId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassEntries", x => x.EntryId);
                    table.ForeignKey(
                        name: "FK_ClassEntries_ClassBatches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "ClassBatches",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassEntries_ClassSections_ClassSectionId",
                        column: x => x.ClassSectionId,
                        principalTable: "ClassSections",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassEntries_UserModels_StudentId",
                        column: x => x.StudentId,
                        principalTable: "UserModels",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ClassBatches_ClassSectionId",
                table: "ClassBatches",
                column: "ClassSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassEntries_BatchId",
                table: "ClassEntries",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassEntries_ClassSectionId",
                table: "ClassEntries",
                column: "ClassSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassEntries_StudentId",
                table: "ClassEntries",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassEntries");

            migrationBuilder.DropTable(
                name: "ClassBatches");

            migrationBuilder.DropColumn(
                name: "YearLevel",
                table: "ClassSections");
        }
    }
}
