using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SneakerStore.Web.Models;
using SneakerStore.Web.Service.IService;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SneakerStore.Web.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponService _couponService;
        private readonly ITokenProvider _tokenProvider;

        public CouponController(ICouponService couponService, ITokenProvider tokenProvider)
        {
            _couponService = couponService;
            _tokenProvider = tokenProvider;
        }

		public async Task<IActionResult> CouponIndex()
		{
			// List to hold the coupons
			List<CouponDto>? list = new();

			// Get the coupons
			ResponseDto? response = await _couponService.GetAllCouponsAsync();

			if (response != null && response.IsSuccess)
			{
				list = JsonConvert.DeserializeObject<List<CouponDto>>(Convert.ToString(response.Result));
			}
			else
			{
				TempData["error"] = response?.Message;
			}

            // Read the token from the cookie
            var token = _tokenProvider.GetToken();

            if (!string.IsNullOrEmpty(token))
			{
				var handler = new JwtSecurityTokenHandler();
				var jwt = handler.ReadJwtToken(token);

				// Extract the role
                var roleClaim = jwt.Claims.FirstOrDefault(u => u.Type == "role")?.Value;

                // Pass the role to the view
                ViewBag.UserRole = roleClaim;
			}

			// Pass the list of coupons to the view
			return View(list);
		}

		public async Task<IActionResult> CouponCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CouponCreate(CouponDto model)
        {
            if (ModelState.IsValid)
            {
                ResponseDto? response = await _couponService.CreateCouponsAsync(model);

                if (response != null && response.IsSuccess)
                {
                    TempData["success"] = "Coupon created successfully";
                    return RedirectToAction(nameof(CouponIndex));
                }
                else
                {
                    TempData["error"] = response?.Message;
                }
            }
            return View(model);
        }

        public async Task<IActionResult> CouponDelete(int couponId)
        {
            ResponseDto? response = await _couponService.GetCouponByIdAsync(couponId);

            if (response != null && response.IsSuccess)
            {
                CouponDto? model = JsonConvert.DeserializeObject<CouponDto>(Convert.ToString(response.Result));
                return View(model);
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CouponDelete(CouponDto couponDto)
        {
            ResponseDto? response = await _couponService.DeleteCouponsAsync(couponDto.CouponId);

            if (response != null && response.IsSuccess)
            {
                TempData["success"] = "Coupon deleted successfully";
                return RedirectToAction(nameof(CouponIndex));
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View(couponDto);
        }

    }
}
