using Microsoft.EntityFrameworkCore.Migrations;

namespace Pare.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Restaurants",
                type: "longtext CHARACTER SET utf8mb4",
                maxLength: 2083,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Restaurants",
                type: "longtext CHARACTER SET utf8mb4",
                maxLength: 2083,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "menuUrl",
                table: "Restaurants",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "menuUrl",
                table: "Restaurants");
        }
    }
}
