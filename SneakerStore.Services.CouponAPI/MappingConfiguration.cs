using AutoMapper;
using SneakerStore.Services.CouponAPI.Models;
using SneakerStore.Services.CouponAPI.Models.Dto;

namespace SneakerStore.Services.CouponAPI
{
    public class MappingConfiguration
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
