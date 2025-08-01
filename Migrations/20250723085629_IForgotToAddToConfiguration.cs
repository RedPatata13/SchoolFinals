using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Y2S1_INC_Compliance_proj.Migrations
{
    /// <inheritdoc />
    public partial class IForgotToAddToConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgramModel",
                columns: table => new
                {
                    ProgramId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProgramName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProgramDescription = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsOpen = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LastEditorId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatorId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramModel", x => x.ProgramId);
                    table.ForeignKey(
                        name: "FK_ProgramModel_UserModels_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "UserModels",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgramModel_UserModels_LastEditorId",
                        column: x => x.LastEditorId,
                        principalTable: "UserModels",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProgramModel_Edits",
                columns: table => new
                {
                    Edit_ID = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Edit = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EditorId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProgramId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramModel_Edits", x => x.Edit_ID);
                    table.ForeignKey(
                        name: "FK_ProgramModel_Edits_ProgramModel_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "ProgramModel",
                        principalColumn: "ProgramId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgramModel_Edits_UserModels_EditorId",
                        column: x => x.EditorId,
                        principalTable: "UserModels",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramModel_CreatorId",
                table: "ProgramModel",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramModel_LastEditorId",
                table: "ProgramModel",
                column: "LastEditorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramModel_Edits_EditorId",
                table: "ProgramModel_Edits",
                column: "EditorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramModel_Edits_ProgramId",
                table: "ProgramModel_Edits",
                column: "ProgramId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgramModel_Edits");

            migrationBuilder.DropTable(
                name: "ProgramModel");
        }
    }
}
