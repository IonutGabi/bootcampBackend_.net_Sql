using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademyManagerWeb.Migrations
{
    /// <inheritdoc />
    public partial class addProfileIdColumnInTeachersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Teachers_TeacherId1",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_TeacherId1",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "TeacherId1",
                table: "Profiles");

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ProfileId",
                table: "Teachers",
                column: "ProfileId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Profiles_ProfileId",
                table: "Teachers",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Profiles_ProfileId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_ProfileId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Teachers");

            migrationBuilder.AddColumn<string>(
                name: "TeacherId",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId1",
                table: "Profiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_TeacherId1",
                table: "Profiles",
                column: "TeacherId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Teachers_TeacherId1",
                table: "Profiles",
                column: "TeacherId1",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
