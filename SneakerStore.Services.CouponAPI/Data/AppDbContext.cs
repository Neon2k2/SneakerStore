using Microsoft.EntityFrameworkCore;
using SneakerStore.Services.CouponAPI.Models;

namespace SneakerStore.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Coupon> Coupons {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(
                new Coupon { CouponId = 1, CouponCode = "10OFF", DiscountAmount = 10, MinAmount = 20 },
                new Coupon { CouponId = 2, CouponCode = "20OFF", DiscountAmount = 20, MinAmount = 50 },
                new Coupon { CouponId = 3, CouponCode = "15OFF", DiscountAmount = 15, MinAmount = 30 },
                new Coupon { CouponId = 4, CouponCode = "25OFF", DiscountAmount = 25, MinAmount = 100 },
                new Coupon { CouponId = 5, CouponCode = "5OFF", DiscountAmount = 5, MinAmount = 10 },
                new Coupon { CouponId = 6, CouponCode = "30OFF", DiscountAmount = 30, MinAmount = 150 },
                new Coupon { CouponId = 7, CouponCode = "FREEDEL", DiscountAmount = 0, MinAmount = 0 },
                new Coupon { CouponId = 8, CouponCode = "50OFF", DiscountAmount = 50, MinAmount = 200 },
                new Coupon { CouponId = 9, CouponCode = "SUMMER20", DiscountAmount = 20, MinAmount = 75 },
                new Coupon { CouponId = 10, CouponCode = "WINTER15", DiscountAmount = 15, MinAmount = 40 },
                new Coupon { CouponId = 11, CouponCode = "FALL10", DiscountAmount = 10, MinAmount = 25 }
            );

        }
    }
}
