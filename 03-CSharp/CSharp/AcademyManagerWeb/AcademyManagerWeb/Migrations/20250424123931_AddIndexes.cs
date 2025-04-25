using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademyManagerWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "UX_Teachers_NameLastName",
                table: "Teachers",
                columns: new[] { "Name", "LastName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UX_Students_NameLastName",
                table: "Students",
                columns: new[] { "Name", "LastName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UX_Courses_CourseName",
                table: "Courses",
                column: "CourseName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UX_Teachers_NameLastName",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "UX_Students_NameLastName",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "UX_Courses_CourseName",
                table: "Courses");
        }
    }
}
