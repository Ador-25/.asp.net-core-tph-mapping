using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tph_mapping.Migrations
{
    public partial class Tph : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClassRollNo",
                table: "UserAccounts",
                newName: "ClassRoll");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClassRoll",
                table: "UserAccounts",
                newName: "ClassRollNo");
        }
    }
}
