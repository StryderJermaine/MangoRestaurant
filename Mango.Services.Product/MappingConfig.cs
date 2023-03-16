using AutoMapper;
using Mango.Services.Product.Models.Dto;

namespace Mango.Services.Product;

public class MappingConfig
{
    public static MapperConfiguration RegisterMapperConfiguration()
    {
        var config = new MapperConfiguration(config =>
        {
            config.CreateMap<ProductDto, Models.Product>().ReverseMap();
        });

        return config;
    }
}