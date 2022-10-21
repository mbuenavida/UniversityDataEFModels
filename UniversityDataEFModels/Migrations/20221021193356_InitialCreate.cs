using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityDataEFModels.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "customSchema");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourName = table.Column<string>(type: "varchar(100)", nullable: false),
                    CourCode = table.Column<string>(type: "varchar(25)", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentRecords",
                schema: "customSchema",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "varchar(100)", nullable: false),
                    LName = table.Column<string>(type: "varchar(150)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModulesRecords",
                schema: "customSchema",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModName = table.Column<string>(type: "varchar(100)", nullable: false),
                    ModCode = table.Column<string>(type: "varchar(25)", nullable: false),
                    Credits = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Mandatory = table.Column<bool>(type: "bit", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulesRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModulesRecords_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModulesRecords_CourseId",
                schema: "customSchema",
                table: "ModulesRecords",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModulesRecords",
                schema: "customSchema");

            migrationBuilder.DropTable(
                name: "StudentRecords",
                schema: "customSchema");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
