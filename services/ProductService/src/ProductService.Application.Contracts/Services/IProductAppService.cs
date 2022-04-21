using ProductService.Dtos;
using System;
using System.Threading.Tasks;

namespace ProductService.Services
{
    public interface IProductAppService
    {
        Task<ProductDto> GetByCategory(Guid categoryId);
        Task<ProductDto> GetByManufacturer(Guid manufacturerId);
    }
}
