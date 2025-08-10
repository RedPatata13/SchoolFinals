using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Finals.Migrations
{
    /// <inheritdoc />
    public partial class TeacherBasicInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Venues");

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "Venues",
                type: "int",
                nullable: false,
                defaultValue: 7);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "TeacherModels",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "TeacherModels",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "TeacherModels",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "TeacherModels");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "TeacherModels");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "TeacherModels");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Venues",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
