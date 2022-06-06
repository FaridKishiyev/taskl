using Microsoft.EntityFrameworkCore.Migrations;

namespace Flowers.Migrations
{
    public partial class Flowers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlowerCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flowername = table.Column<string>(nullable: true),
                    FlowerImg = table.Column<string>(nullable: true),
                    FlowerPricing = table.Column<float>(nullable: false),
                    FlowerDescription = table.Column<string>(nullable: true),
                    FlowerCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowerCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlowerCard_Category_FlowerCategoryId",
                        column: x => x.FlowerCategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlowerCard_FlowerCategoryId",
                table: "FlowerCard",
                column: "FlowerCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlowerCard");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
