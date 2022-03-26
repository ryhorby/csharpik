using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharpik.Data.Migrations
{
    public partial class changeAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Authors",
                newName: "Biography");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Biography",
                table: "Authors",
                newName: "Surname");
        }
    }
}
