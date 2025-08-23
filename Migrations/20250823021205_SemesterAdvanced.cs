using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finals.Migrations
{
    /// <inheritdoc />
    public partial class SemesterAdvanced : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StandardSemesterId",
                table: "Semesters",
                type: "varchar(30)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Semesters_StandardSemesterId",
                table: "Semesters",
                column: "StandardSemesterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Semesters_Semesters_StandardSemesterId",
                table: "Semesters",
                column: "StandardSemesterId",
                principalTable: "Semesters",
                principalColumn: "SemesterId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Semesters_Semesters_StandardSemesterId",
                table: "Semesters");

            migrationBuilder.DropIndex(
                name: "IX_Semesters_StandardSemesterId",
                table: "Semesters");

            migrationBuilder.DropColumn(
                name: "StandardSemesterId",
                table: "Semesters");
        }
    }
}
