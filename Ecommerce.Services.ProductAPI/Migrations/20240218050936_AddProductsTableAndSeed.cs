using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddProductsTableAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageLocalPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageLocalPath", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Tops", "A timeless staple for any wardrobe, the classic white T-shirt is made from 100% soft cotton for maximum comfort. Perfect for casual wear or layering.<br/>Tailored fit with a crew neckline for a sleek look.", null, "https://placehold.co/603x403", "Classic White T-Shirt", 25.0 },
                    { 2, "Bottoms", "Our denim jeans feature a classic straight-leg cut with a hint of stretch for comfort. The deep indigo wash offers versatility for both casual and semi-formal looks.<br/>Five-pocket styling with a button closure and zip fly.", null, "https://placehold.co/603x403", "Denim Jeans", 50.0 },
                    { 3, "Outerwear", "Crafted from premium genuine leather, this jacket is a symbol of timeless style. Features a zip front, stand-up collar, and quilted lining for warmth.<br/>Perfect for adding an edge to any outfit.", null, "https://placehold.co/603x403", "Leather Jacket", 120.0 },
                    { 4, "Knitwear", "Luxuriously soft, this 100% cashmere sweater offers unparalleled comfort and warmth. The subtle ribbing at the cuffs, hem, and crew neck adds a touch of elegance.<br/>Ideal for layering during colder months.", null, "https://placehold.co/603x403", "Cashmere Sweater", 80.0 },
                    { 5, "Accessories", "Add a pop of color to your ensemble with our pure silk scarf. The lightweight, smooth fabric drapes beautifully and can be styled in various ways.<br/>Featuring an exclusive print for a unique touch.", null, "https://placehold.co/603x403", "Silk Scarf", 35.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
