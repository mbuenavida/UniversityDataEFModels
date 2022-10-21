using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityDataEFModels.Migrations
{
    public partial class TablesCorrections01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModulesRecords_Courses_CourseId",
                schema: "customSchema",
                table: "ModulesRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "CourseRecords",
                newSchema: "customSchema");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseRecords",
                schema: "customSchema",
                table: "CourseRecords",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModulesRecords_CourseRecords_CourseId",
                schema: "customSchema",
                table: "ModulesRecords",
                column: "CourseId",
                principalSchema: "customSchema",
                principalTable: "CourseRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModulesRecords_CourseRecords_CourseId",
                schema: "customSchema",
                table: "ModulesRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseRecords",
                schema: "customSchema",
                table: "CourseRecords");

            migrationBuilder.RenameTable(
                name: "CourseRecords",
                schema: "customSchema",
                newName: "Courses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModulesRecords_Courses_CourseId",
                schema: "customSchema",
                table: "ModulesRecords",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
