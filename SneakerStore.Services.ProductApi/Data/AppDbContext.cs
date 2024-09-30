using Microsoft.EntityFrameworkCore;
using SneakerStore.Services.ProductApi.Models;



namespace SneakerStore.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Product> Products {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Air Jordan 1 Retro High", Price = 199.99, Description = "Classic red and black high-tops", CategoryName = "Sneakers", ImageUrl = "https://example.com/images/air_jordan_1.jpg" },
                new Product { ProductId = 2, Name = "Adidas Yeezy Boost 350 V2", Price = 299.99, Description = "Ultra-comfortable with a sleek design", CategoryName = "Sneakers", ImageUrl = "https://example.com/images/yeezy_boost_350.jpg" },
                new Product { ProductId = 3, Name = "Nike Air Max 90", Price = 149.99, Description = "Timeless running shoes with a bold look", CategoryName = "Sneakers", ImageUrl = "https://example.com/images/air_max_90.jpg" },
                new Product { ProductId = 4, Name = "Puma Suede Classic", Price = 89.99, Description = "Iconic suede sneakers", CategoryName = "Sneakers", ImageUrl = "https://example.com/images/puma_suede.jpg" },
                new Product { ProductId = 5, Name = "Reebok Club C 85", Price = 74.99, Description = "Retro-inspired sneakers", CategoryName = "Sneakers", ImageUrl = "https://example.com/images/reebok_club_c.jpg" },
                new Product { ProductId = 6, Name = "New Balance 990v5", Price = 179.99, Description = "Comfort meets style in these everyday trainers", CategoryName = "Sneakers", ImageUrl = "https://example.com/images/new_balance_990.jpg" },
                new Product { ProductId = 7, Name = "Converse Chuck Taylor All Star", Price = 55.00, Description = "The timeless canvas shoes", CategoryName = "Sneakers", ImageUrl = "https://example.com/images/converse_chuck_taylor.jpg" },
                new Product { ProductId = 8, Name = "Vans Old Skool", Price = 60.00, Description = "Skater's favorite with a stripe", CategoryName = "Sneakers", ImageUrl = "https://example.com/images/vans_old_skool.jpg" },
                new Product { ProductId = 9, Name = "Under Armour Curry 7", Price = 159.99, Description = "Performance basketball shoes", CategoryName = "Sneakers", ImageUrl = "https://example.com/images/under_armour_curry.jpg" },
                new Product { ProductId = 10, Name = "ASICS Gel-Kayano 26", Price = 179.99, Description = "Ultimate support for long-distance running", CategoryName = "Sneakers", ImageUrl = "https://example.com/images/asics_gel_kayano.jpg" }
            );

        }
    }
}
