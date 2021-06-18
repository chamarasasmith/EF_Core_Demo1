using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core_Demo1.Migrations
{
    public partial class _20200601 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Course",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Course");
        }
    }
}
