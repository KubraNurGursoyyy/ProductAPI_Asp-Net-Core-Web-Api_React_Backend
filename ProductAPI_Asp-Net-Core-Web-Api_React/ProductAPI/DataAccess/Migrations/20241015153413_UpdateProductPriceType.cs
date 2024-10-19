using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class UpdateProductPriceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.AlterColumn<decimal>(
           name: "Price",
           table: "Products",
           type: "decimal(18,2)", 
           nullable: false,
           oldClrType: typeof(decimal),
           oldType: "decimal(18, 38)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
            name: "Price",
            table: "Products",
            type: "decimal(18, 38)",
            nullable: false,
            oldClrType: typeof(decimal),
            oldType: "decimal(18,2)");
        }
    }
}
