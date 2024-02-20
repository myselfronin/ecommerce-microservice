using AutoMapper;
using Ecommerce.Services.ShoppingCartAPI.Models;
using Ecommerce.Services.ShoppingCartAPI.Models.Dto;

namespace Ecommerce.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeaderDto, CartHeader>().ReverseMap();
                config.CreateMap<CartDetailsDto, CartDetails>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
