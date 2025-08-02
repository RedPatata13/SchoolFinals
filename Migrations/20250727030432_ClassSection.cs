using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finals.Migrations
{
    /// <inheritdoc />
    public partial class ClassSection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassSections",
                columns: table => new
                {
                    SectionID = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SectionName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSections", x => x.SectionID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClassSectionModelUserModel",
                columns: table => new
                {
                    ClassSectionModelSectionID = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StudentsUserID = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSectionModelUserModel", x => new { x.ClassSectionModelSectionID, x.StudentsUserID });
                    table.ForeignKey(
                        name: "FK_ClassSectionModelUserModel_ClassSections_ClassSectionModelSe~",
                        column: x => x.ClassSectionModelSectionID,
                        principalTable: "ClassSections",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSectionModelUserModel_UserModels_StudentsUserID",
                        column: x => x.StudentsUserID,
                        principalTable: "UserModels",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClassSectionsEdits",
                columns: table => new
                {
                    LogId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SectionId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EditedByUserId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EditDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EditDescription = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EditType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSectionsEdits", x => x.LogId);
                    table.ForeignKey(
                        name: "FK_ClassSectionsEdits_ClassSections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "ClassSections",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassSectionsEdits_UserModels_EditedByUserId",
                        column: x => x.EditedByUserId,
                        principalTable: "UserModels",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClassSectionTransitions",
                columns: table => new
                {
                    TransitionId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FromSectionId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ToSectionId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TransitionPercentage = table.Column<double>(type: "double", precision: 5, scale: 2, nullable: false),
                    IsLocked = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSectionTransitions", x => x.TransitionId);
                    table.ForeignKey(
                        name: "FK_ClassSectionTransitions_ClassSections_FromSectionId",
                        column: x => x.FromSectionId,
                        principalTable: "ClassSections",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassSectionTransitions_ClassSections_ToSectionId",
                        column: x => x.ToSectionId,
                        principalTable: "ClassSections",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSectionModelUserModel_StudentsUserID",
                table: "ClassSectionModelUserModel",
                column: "StudentsUserID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSectionsEdits_EditedByUserId",
                table: "ClassSectionsEdits",
                column: "EditedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSectionsEdits_SectionId",
                table: "ClassSectionsEdits",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSectionTransitions_FromSectionId",
                table: "ClassSectionTransitions",
                column: "FromSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSectionTransitions_ToSectionId",
                table: "ClassSectionTransitions",
                column: "ToSectionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassSectionModelUserModel");

            migrationBuilder.DropTable(
                name: "ClassSectionsEdits");

            migrationBuilder.DropTable(
                name: "ClassSectionTransitions");

            migrationBuilder.DropTable(
                name: "ClassSections");
        }
    }
}
