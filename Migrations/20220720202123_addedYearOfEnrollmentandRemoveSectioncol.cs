using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkAssignment.Migrations
{
    public partial class addedYearOfEnrollmentandRemoveSectioncol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "section",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "yearOfEnrollment",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 2020);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "yearOfEnrollment",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "section",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
