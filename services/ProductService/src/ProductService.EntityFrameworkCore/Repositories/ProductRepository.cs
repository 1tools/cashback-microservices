using ProductService.Entities;
using ProductService.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ProductService.Repositories
{
    public class ProductRepository : EfCoreRepository<ProductServiceDbContext, Product, Guid>,  IProductRepository
    {
        public ProductRepository(IDbContextProvider<ProductServiceDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<ICollection<Product>> GetByCategory(Guid categoryId)
        {
            var dbContex = await GetDbContextAsync();
            return dbContex.Set<Product>().Where(p => p.CategoryId == categoryId).ToList();
        }

        public async Task<ICollection<Product>> GetByManufacturer(Guid manufacturerId)
        {
            var dbContex = await GetDbContextAsync();
            return dbContex.Set<Product>().Where(p => p.ManufacturerId == manufacturerId).ToList();
        }
    }
}
