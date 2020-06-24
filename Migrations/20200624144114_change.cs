using Microsoft.EntityFrameworkCore.Migrations;

namespace CmsShoppingCart.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Context",
                table: "Pages");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            _ = migrationBuilder.DropColumn(
                name: "Content",
                table: "Pages");

            migrationBuilder.AddColumn<string>(
                name: "Context",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
