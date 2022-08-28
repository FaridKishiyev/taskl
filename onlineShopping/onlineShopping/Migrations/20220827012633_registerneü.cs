using Microsoft.EntityFrameworkCore.Migrations;

namespace onlineShopping.Migrations
{
    public partial class registerneü : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "registerStart");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "registerStart");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "registerStart",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "registerStart",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
