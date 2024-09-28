using SneakerStore.Web.Models;

namespace SneakerStore.Web.Service
{
    public interface ICouponService
    {
        public Task<ResponseDto?> GetCouponAsync(string couponCode);
        public Task<ResponseDto?> GetAllCouponsAsync();
        public Task<ResponseDto?> GetCouponByIdAsync(int id);
        public Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto);
        public Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto);
        public Task<ResponseDto?> DeleteCouponsAsync(int couponId);
    }
}
