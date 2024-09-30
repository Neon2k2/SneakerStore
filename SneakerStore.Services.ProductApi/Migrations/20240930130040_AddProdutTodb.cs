using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SneakerStore.Services.ProductApi.Migrations
{
    /// <inheritdoc />
    public partial class AddProdutTodb : Migration
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
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Sneakers", "Classic red and black high-tops", "https://example.com/images/air_jordan_1.jpg", "Air Jordan 1 Retro High", 199.99000000000001 },
                    { 2, "Sneakers", "Ultra-comfortable with a sleek design", "https://example.com/images/yeezy_boost_350.jpg", "Adidas Yeezy Boost 350 V2", 299.99000000000001 },
                    { 3, "Sneakers", "Timeless running shoes with a bold look", "https://example.com/images/air_max_90.jpg", "Nike Air Max 90", 149.99000000000001 },
                    { 4, "Sneakers", "Iconic suede sneakers", "https://example.com/images/puma_suede.jpg", "Puma Suede Classic", 89.989999999999995 },
                    { 5, "Sneakers", "Retro-inspired sneakers", "https://example.com/images/reebok_club_c.jpg", "Reebok Club C 85", 74.989999999999995 },
                    { 6, "Sneakers", "Comfort meets style in these everyday trainers", "https://example.com/images/new_balance_990.jpg", "New Balance 990v5", 179.99000000000001 },
                    { 7, "Sneakers", "The timeless canvas shoes", "https://example.com/images/converse_chuck_taylor.jpg", "Converse Chuck Taylor All Star", 55.0 },
                    { 8, "Sneakers", "Skater's favorite with a stripe", "https://example.com/images/vans_old_skool.jpg", "Vans Old Skool", 60.0 },
                    { 9, "Sneakers", "Performance basketball shoes", "https://example.com/images/under_armour_curry.jpg", "Under Armour Curry 7", 159.99000000000001 },
                    { 10, "Sneakers", "Ultimate support for long-distance running", "https://example.com/images/asics_gel_kayano.jpg", "ASICS Gel-Kayano 26", 179.99000000000001 }
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
