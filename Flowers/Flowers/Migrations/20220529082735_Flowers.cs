using Microsoft.EntityFrameworkCore.Migrations;

namespace Flowers.Migrations
{
    public partial class Flowers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlowerCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flowername = table.Column<string>(nullable: true),
                    FlowerImg = table.Column<string>(nullable: true),
                    FlowerPricing = table.Column<int>(nullable: false),
                    FlowerDescription = table.Column<string>(nullable: true),
                    FlowerCategory = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowerCard", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlowerCard");
        }
    }
}
