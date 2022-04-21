using AutoMapper;
using ProductService.Dtos;
using ProductService.Entities;

namespace ProductService;

public class ProductServiceApplicationAutoMapperProfile : Profile
{
    public ProductServiceApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<Manufacturer, ManufacturerDto>().ReverseMap();
        CreateMap<Category, CategoryDto>().ReverseMap();
    }
}
