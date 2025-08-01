using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Y2S1_INC_Compliance_proj.Migrations
{
    /// <inheritdoc />
    public partial class ProgramAndClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProgramId",
                table: "ClassSections",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSections_ProgramId",
                table: "ClassSections",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSections_programmodel_ProgramId",
                table: "ClassSections",
                column: "ProgramId",
                principalTable: "programmodel",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassSections_programmodel_ProgramId",
                table: "ClassSections");

            migrationBuilder.DropIndex(
                name: "IX_ClassSections_ProgramId",
                table: "ClassSections");

            migrationBuilder.DropColumn(
                name: "ProgramId",
                table: "ClassSections");
        }
    }
}
