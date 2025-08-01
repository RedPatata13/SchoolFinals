using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Y2S1_INC_Compliance_proj.Migrations
{
    /// <inheritdoc />
    public partial class TableNameCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProgramModel_UserModels_CreatorId",
                table: "ProgramModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgramModel_UserModels_LastEditorId",
                table: "ProgramModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgramModel_Edits_ProgramModel_ProgramId",
                table: "ProgramModel_Edits");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgramModel_Edits_UserModels_EditorId",
                table: "ProgramModel_Edits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgramModel_Edits",
                table: "ProgramModel_Edits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProgramModel",
                table: "ProgramModel");

            migrationBuilder.RenameTable(
                name: "ProgramModel_Edits",
                newName: "programmodel_edits");

            migrationBuilder.RenameTable(
                name: "ProgramModel",
                newName: "programmodel");

            migrationBuilder.RenameIndex(
                name: "IX_ProgramModel_Edits_ProgramId",
                table: "programmodel_edits",
                newName: "IX_programmodel_edits_ProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_ProgramModel_Edits_EditorId",
                table: "programmodel_edits",
                newName: "IX_programmodel_edits_EditorId");

            migrationBuilder.RenameIndex(
                name: "IX_ProgramModel_LastEditorId",
                table: "programmodel",
                newName: "IX_programmodel_LastEditorId");

            migrationBuilder.RenameIndex(
                name: "IX_ProgramModel_CreatorId",
                table: "programmodel",
                newName: "IX_programmodel_CreatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_programmodel_edits",
                table: "programmodel_edits",
                column: "Edit_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_programmodel",
                table: "programmodel",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_programmodel_UserModels_CreatorId",
                table: "programmodel",
                column: "CreatorId",
                principalTable: "UserModels",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_programmodel_UserModels_LastEditorId",
                table: "programmodel",
                column: "LastEditorId",
                principalTable: "UserModels",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_programmodel_edits_UserModels_EditorId",
                table: "programmodel_edits",
                column: "EditorId",
                principalTable: "UserModels",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_programmodel_edits_programmodel_ProgramId",
                table: "programmodel_edits",
                column: "ProgramId",
                principalTable: "programmodel",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_programmodel_UserModels_CreatorId",
                table: "programmodel");

            migrationBuilder.DropForeignKey(
                name: "FK_programmodel_UserModels_LastEditorId",
                table: "programmodel");

            migrationBuilder.DropForeignKey(
                name: "FK_programmodel_edits_UserModels_EditorId",
                table: "programmodel_edits");

            migrationBuilder.DropForeignKey(
                name: "FK_programmodel_edits_programmodel_ProgramId",
                table: "programmodel_edits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_programmodel_edits",
                table: "programmodel_edits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_programmodel",
                table: "programmodel");

            migrationBuilder.RenameTable(
                name: "programmodel_edits",
                newName: "ProgramModel_Edits");

            migrationBuilder.RenameTable(
                name: "programmodel",
                newName: "ProgramModel");

            migrationBuilder.RenameIndex(
                name: "IX_programmodel_edits_ProgramId",
                table: "ProgramModel_Edits",
                newName: "IX_ProgramModel_Edits_ProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_programmodel_edits_EditorId",
                table: "ProgramModel_Edits",
                newName: "IX_ProgramModel_Edits_EditorId");

            migrationBuilder.RenameIndex(
                name: "IX_programmodel_LastEditorId",
                table: "ProgramModel",
                newName: "IX_ProgramModel_LastEditorId");

            migrationBuilder.RenameIndex(
                name: "IX_programmodel_CreatorId",
                table: "ProgramModel",
                newName: "IX_ProgramModel_CreatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgramModel_Edits",
                table: "ProgramModel_Edits",
                column: "Edit_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProgramModel",
                table: "ProgramModel",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramModel_UserModels_CreatorId",
                table: "ProgramModel",
                column: "CreatorId",
                principalTable: "UserModels",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramModel_UserModels_LastEditorId",
                table: "ProgramModel",
                column: "LastEditorId",
                principalTable: "UserModels",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramModel_Edits_ProgramModel_ProgramId",
                table: "ProgramModel_Edits",
                column: "ProgramId",
                principalTable: "ProgramModel",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgramModel_Edits_UserModels_EditorId",
                table: "ProgramModel_Edits",
                column: "EditorId",
                principalTable: "UserModels",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
