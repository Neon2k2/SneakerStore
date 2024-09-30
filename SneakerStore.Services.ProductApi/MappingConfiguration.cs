using AutoMapper;
using SneakerStore.Services.ProductApi.Model.Dto;
using SneakerStore.Services.ProductApi.Models;

namespace SneakerStore.Services.ProductApi
{
    public class MappingConfiguration
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}

