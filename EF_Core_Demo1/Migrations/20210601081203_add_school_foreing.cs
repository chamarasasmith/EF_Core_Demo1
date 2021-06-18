using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core_Demo1.Migrations
{
    public partial class add_school_foreing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchoolID",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Student_SchoolID",
                table: "Student",
                column: "SchoolID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_School_SchoolID",
                table: "Student",
                column: "SchoolID",
                principalTable: "School",
                principalColumn: "SchoolID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_School_SchoolID",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_SchoolID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "SchoolID",
                table: "Student");
        }
    }
}
