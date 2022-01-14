using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Azen.Migrations
{
    public partial class discountPriceAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DiscountDate",
                table: "SizeColorToProducts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPrice",
                table: "SizeColorToProducts",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountDate",
                table: "SizeColorToProducts");

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "SizeColorToProducts");
        }
    }
}
