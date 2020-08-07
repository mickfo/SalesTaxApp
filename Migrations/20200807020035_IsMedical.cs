using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesTaxApp.Migrations
{
    public partial class IsMedical : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMedical",
                table: "Products",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMedical",
                table: "Products");
        }
    }
}
