using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SneakerStore.Services.CouponAPI.Migrations
{
    /// <inheritdoc />
    public partial class SEEDCOUPONTABLE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coupon",
                columns: new[] { "CouponId", "CouponCode", "DiscountAmount", "MinAmount" },
                values: new object[,]
                {
                    { 1, "10OFF", 10.0, 20 },
                    { 2, "20OFF", 20.0, 50 },
                    { 3, "15OFF", 15.0, 30 },
                    { 4, "25OFF", 25.0, 100 },
                    { 5, "5OFF", 5.0, 10 },
                    { 6, "30OFF", 30.0, 150 },
                    { 7, "FREEDEL", 0.0, 0 },
                    { 8, "50OFF", 50.0, 200 },
                    { 9, "SUMMER20", 20.0, 75 },
                    { 10, "WINTER15", 15.0, 40 },
                    { 11, "FALL10", 10.0, 25 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Coupon",
                keyColumn: "CouponId",
                keyValue: 11);
        }
    }
}
