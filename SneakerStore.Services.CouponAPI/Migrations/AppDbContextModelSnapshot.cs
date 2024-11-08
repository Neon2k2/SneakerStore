﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SneakerStore.Services.CouponAPI.Data;

#nullable disable

namespace SneakerStore.Services.CouponAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SneakerStore.Services.CouponAPI.Models.Coupon", b =>
                {
                    b.Property<int>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CouponId"));

                    b.Property<string>("CouponCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<int>("MinAmount")
                        .HasColumnType("int");

                    b.HasKey("CouponId");

                    b.ToTable("Coupons");

                    b.HasData(
                        new
                        {
                            CouponId = 1,
                            CouponCode = "10OFF",
                            DiscountAmount = 10.0,
                            MinAmount = 20
                        },
                        new
                        {
                            CouponId = 2,
                            CouponCode = "20OFF",
                            DiscountAmount = 20.0,
                            MinAmount = 50
                        },
                        new
                        {
                            CouponId = 3,
                            CouponCode = "15OFF",
                            DiscountAmount = 15.0,
                            MinAmount = 30
                        },
                        new
                        {
                            CouponId = 4,
                            CouponCode = "25OFF",
                            DiscountAmount = 25.0,
                            MinAmount = 100
                        },
                        new
                        {
                            CouponId = 5,
                            CouponCode = "5OFF",
                            DiscountAmount = 5.0,
                            MinAmount = 10
                        },
                        new
                        {
                            CouponId = 6,
                            CouponCode = "30OFF",
                            DiscountAmount = 30.0,
                            MinAmount = 150
                        },
                        new
                        {
                            CouponId = 7,
                            CouponCode = "FREEDEL",
                            DiscountAmount = 0.0,
                            MinAmount = 0
                        },
                        new
                        {
                            CouponId = 8,
                            CouponCode = "50OFF",
                            DiscountAmount = 50.0,
                            MinAmount = 200
                        },
                        new
                        {
                            CouponId = 9,
                            CouponCode = "SUMMER20",
                            DiscountAmount = 20.0,
                            MinAmount = 75
                        },
                        new
                        {
                            CouponId = 10,
                            CouponCode = "WINTER15",
                            DiscountAmount = 15.0,
                            MinAmount = 40
                        },
                        new
                        {
                            CouponId = 11,
                            CouponCode = "FALL10",
                            DiscountAmount = 10.0,
                            MinAmount = 25
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
