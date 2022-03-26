using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharpik.Data.Migrations
{
    public partial class ChengeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_UrlKeepers_Books_BookId",
                table: "UrlKeepers");

            migrationBuilder.DropIndex(
                name: "IX_UrlKeepers_BookId",
                table: "UrlKeepers");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UrlKeepers_BookId",
                table: "UrlKeepers",
                column: "BookId",
                unique: true,
                filter: "[BookId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UrlKeepers_Books_BookId",
                table: "UrlKeepers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
