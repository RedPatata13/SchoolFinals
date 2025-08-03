using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finals.Migrations
{
    /// <inheritdoc />
    public partial class GradesTree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GradesClassifications",
                columns: table => new
                {
                    GradesClassificationId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<double>(type: "double", nullable: false, defaultValue: -1.0),
                    Depth = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ParentId = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradesClassifications", x => x.GradesClassificationId);
                    table.ForeignKey(
                        name: "FK_GradesClassifications_GradesClassifications_ParentId",
                        column: x => x.ParentId,
                        principalTable: "GradesClassifications",
                        principalColumn: "GradesClassificationId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GradesTreeConfigurations",
                columns: table => new
                {
                    TreeId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TreeName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RootId = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    TreeType = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradesTreeConfigurations", x => x.TreeId);
                    table.ForeignKey(
                        name: "FK_GradesTreeConfigurations_GradesClassifications_RootId",
                        column: x => x.RootId,
                        principalTable: "GradesClassifications",
                        principalColumn: "GradesClassificationId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_GradesClassifications_ParentId",
                table: "GradesClassifications",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_GradesTreeConfigurations_RootId",
                table: "GradesTreeConfigurations",
                column: "RootId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GradesTreeConfigurations");

            migrationBuilder.DropTable(
                name: "GradesClassifications");
        }
    }
}
