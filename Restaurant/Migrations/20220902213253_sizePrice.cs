using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.Migrations
{
    public partial class sizePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Size",
                schema: "dto",
                table: "Item",
                newName: "SizePrice");

            migrationBuilder.AddColumn<string>(
                name: "SizeName",
                schema: "dto",
                table: "Item",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SizeName",
                schema: "dto",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "SizePrice",
                schema: "dto",
                table: "Item",
                newName: "Size");
        }
    }
}
