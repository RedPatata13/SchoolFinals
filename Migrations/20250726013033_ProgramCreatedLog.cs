using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Y2S1_INC_Compliance_proj.Migrations
{
    /// <inheritdoc />
    public partial class ProgramCreatedLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EditedAt",
                table: "programmodel_edits",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EditedAt",
                table: "programmodel_edits");
        }
    }
}
