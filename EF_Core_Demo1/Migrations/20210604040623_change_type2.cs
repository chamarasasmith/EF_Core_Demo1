using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core_Demo1.Migrations
{
    public partial class change_type2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey("PK_Enrollment", "Enrollment");

            migrationBuilder.AlterColumn<long>(
                name: "EnrollmentID",
                table: "Enrollment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey("PK_Enrollment", "Enrollment", "EnrollmentID");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey("PK_Enrollment", "Enrollment");

            migrationBuilder.AlterColumn<int>(
                name: "EnrollmentID",
                table: "Enrollment",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey("PK_Enrollment", "Enrollment", "EnrollmentID");


        }
    }
}
