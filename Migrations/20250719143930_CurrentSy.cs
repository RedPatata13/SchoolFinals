using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Y2S1_INC_Compliance_proj.Migrations
{
    /// <inheritdoc />
    public partial class CurrentSy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SemesterModel_SchoolYearModel_SchoolYearId",
                table: "SemesterModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SemesterModel",
                table: "SemesterModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SchoolYearModel",
                table: "SchoolYearModel");

            migrationBuilder.RenameTable(
                name: "SemesterModel",
                newName: "Semesters");

            migrationBuilder.RenameTable(
                name: "SchoolYearModel",
                newName: "SchoolYearModels");

            migrationBuilder.RenameIndex(
                name: "IX_SemesterModel_SchoolYearId",
                table: "Semesters",
                newName: "IX_Semesters_SchoolYearId");

            migrationBuilder.AddColumn<bool>(
                name: "IsCurrent",
                table: "SchoolYearModels",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Semesters",
                table: "Semesters",
                column: "SemesterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SchoolYearModels",
                table: "SchoolYearModels",
                column: "SchoolYearId");

            migrationBuilder.AddForeignKey(
                name: "FK_Semesters_SchoolYearModels_SchoolYearId",
                table: "Semesters",
                column: "SchoolYearId",
                principalTable: "SchoolYearModels",
                principalColumn: "SchoolYearId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Semesters_SchoolYearModels_SchoolYearId",
                table: "Semesters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Semesters",
                table: "Semesters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SchoolYearModels",
                table: "SchoolYearModels");

            migrationBuilder.DropColumn(
                name: "IsCurrent",
                table: "SchoolYearModels");

            migrationBuilder.RenameTable(
                name: "Semesters",
                newName: "SemesterModel");

            migrationBuilder.RenameTable(
                name: "SchoolYearModels",
                newName: "SchoolYearModel");

            migrationBuilder.RenameIndex(
                name: "IX_Semesters_SchoolYearId",
                table: "SemesterModel",
                newName: "IX_SemesterModel_SchoolYearId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SemesterModel",
                table: "SemesterModel",
                column: "SemesterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SchoolYearModel",
                table: "SchoolYearModel",
                column: "SchoolYearId");

            migrationBuilder.AddForeignKey(
                name: "FK_SemesterModel_SchoolYearModel_SchoolYearId",
                table: "SemesterModel",
                column: "SchoolYearId",
                principalTable: "SchoolYearModel",
                principalColumn: "SchoolYearId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
