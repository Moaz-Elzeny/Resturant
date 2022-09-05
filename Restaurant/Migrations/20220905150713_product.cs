using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.Migrations
{
    public partial class product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                schema: "dto",
                table: "Product",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductPhoto",
                schema: "dto",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductPrice",
                schema: "dto",
                table: "Product",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductSize",
                schema: "dto",
                table: "Product",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                schema: "dto",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductPhoto",
                schema: "dto",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductPrice",
                schema: "dto",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductSize",
                schema: "dto",
                table: "Product");
        }
    }
}
