using Microsoft.EntityFrameworkCore.Migrations;

namespace Flowers.Migrations
{
    public partial class addCountColumFlower : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "FlowerCard",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "FlowerCard");
        }
    }
}
