using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finals.Migrations
{
    /// <inheritdoc />
    public partial class RemoveStudentsFromClassSectionModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassSectionModelUserModel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_ClassSectionModelUserModel_StudentsUserID",
                table: "ClassSectionModelUserModel",
                column: "StudentsUserID");
        }
    }
}
