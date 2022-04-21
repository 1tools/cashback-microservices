using ProductService.Dtos;
using ProductService.Entities;
using ProductService.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ProductService.Services
{
    public class ProductAppService : CrudAppService<Product, ProductDto, Guid>, IProductAppService
    {
        private readonly IRepository<Product, Guid> repository;
        private readonly IProductRepository customRepository;

        public ProductAppService(IRepository<Product, Guid> repository, IProductRepository customRepository) : base(repository)
        {
            this.repository = repository;
            this.customRepository = customRepository;
        }

        public async Task<ICollection<ProductDto>> GetByCategory(Guid categoryId)
        {
            return await customRepository.GetByCategory(categoryId);
        }

        public Task<ProductDto> GetByManufacturer(Guid manufacturerId)
        {
            throw new NotImplementedException();
        }
    }
}
