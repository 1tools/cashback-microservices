using ProductService.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace ProductService.Repositories
{
    public interface IProductRepository: IRepository<Product, Guid>
    {
        Task<ICollection<Product>> GetByCategory(Guid categoryId);
        Task<ICollection<Product>> GetByManufacturer(Guid manufacturerId);
    }
}
