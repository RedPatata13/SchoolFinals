using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finals.Migrations
{
    /// <inheritdoc />
    public partial class UserCreator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatorId",
                table: "UserModels",
                type: "varchar(50)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_UserModels_CreatorId",
                table: "UserModels",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserModels_UserModels_CreatorId",
                table: "UserModels",
                column: "CreatorId",
                principalTable: "UserModels",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserModels_UserModels_CreatorId",
                table: "UserModels");

            migrationBuilder.DropIndex(
                name: "IX_UserModels_CreatorId",
                table: "UserModels");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "UserModels");
        }
    }
}
