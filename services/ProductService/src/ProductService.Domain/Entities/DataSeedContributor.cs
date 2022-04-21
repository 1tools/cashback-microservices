using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace ProductService.Entities
{
    internal class DataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Category, Guid> categoryResponsitory;
        private readonly IRepository<Manufacturer, Guid> manufacturerReponsitory;
        private readonly IRepository<Product, Guid> productRespository;

        public DataSeedContributor(
            IRepository<Category, Guid> categoryResponsitory,
            IRepository<Manufacturer, Guid> manufacturerReponsitory,
            IRepository<Product, Guid> productRespository)
        {
            this.categoryResponsitory = categoryResponsitory;
            this.manufacturerReponsitory = manufacturerReponsitory;
            this.productRespository = productRespository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            await SeedManufacturersAsync(context);
            await SeedCategoriesAsync(context);
            await SeedProductsAsync(context);
        }
        private async Task SeedManufacturersAsync(DataSeedContext context)
        {
            if ((await manufacturerReponsitory.GetCountAsync()) == 0)
            {
                var manufacturers = new List<Manufacturer> {
                    new Manufacturer { Name = "Xiaomi", Logo = "https://i.imgur.com/DNxq3h6.png", Address = "China" },
                    new Manufacturer { Name = "Samsung", Logo = "https://i.imgur.com/MQWDGMD.png", Address = "Korea" },
                    new Manufacturer { Name = "Apple", Logo = "https://i.imgur.com/FQXhBZ6.png", Address = "USA" }
                };
                await manufacturerReponsitory.InsertManyAsync(manufacturers);
            }
            
        }
        private async Task SeedCategoriesAsync(DataSeedContext context)
        {
            if ((await categoryResponsitory.GetCountAsync()) == 0)
            {
                var categories = new List<Category> {
                    new Category {Name = "Mobile Phone", Description = "Mobile phone"},
                    new Category {Name = "Smartwatch", Description = "Mobile phone"},
                };
                await categoryResponsitory.InsertManyAsync(categories);
                
            }
            
        }
        private async Task SeedProductsAsync(DataSeedContext context)
        {
            if ((await productRespository.GetCountAsync()) == 0)
            {
                var xiaomi = await manufacturerReponsitory.FirstOrDefaultAsync(t => t.Name == "Xiaomi");
                var apple = await manufacturerReponsitory.FirstOrDefaultAsync(t => t.Name == "Apple");
                var samsung = await manufacturerReponsitory.FirstOrDefaultAsync(t => t.Name == "Samsung");
                var smartWatch = await categoryResponsitory.FirstOrDefaultAsync(t => t.Name == "Smartwatch");
                var mobilePhone = await categoryResponsitory.FirstOrDefaultAsync(t => t.Name == "Mobile Phone");

                var products = new List<Product>
                {
                    // Xiaomi
                    new Product {Name = "Redmi note 12", Price = 10000000, Quantity = 10, Image = "https://i.imgur.com/1Q849hE.png", CashbackPercent = 10, CashbackMaximumValue = 2000000, CategoryId = mobilePhone.Id, ManufacturerId = xiaomi.Id},
                    new Product {Name = "Miwatch 1", Price = 4900000, Quantity = 20, Image = "https://i.imgur.com/wau0xOV.png", CashbackPercent = 10, CashbackMaximumValue = 11, CategoryId = smartWatch.Id, ManufacturerId = xiaomi.Id},
                    // Apple
                    new Product {Name = "Iphone 13", Price = 20000000, Quantity = 1, Image = "https://i.imgur.com/NuOGMQK.png", CashbackPercent = 4, CashbackMaximumValue = 1000000, CategoryId = mobilePhone.Id, ManufacturerId = apple.Id},
                    new Product {Name = "Apple Watch series 6", Price = 5600000, Quantity = 20, Image = "https://i.imgur.com/OyKaoPW.png", CashbackPercent = 10, CashbackMaximumValue = 11, CategoryId = smartWatch.Id, ManufacturerId = apple.Id},
                    // Samsung
                    new Product {Name = "Samsung Galaxy A12 (4GB/128GB)", Price = 4200000, Quantity = 10, Image = "https://i.imgur.com/AYCEtQy.png", CashbackPercent = 10, CashbackMaximumValue = 500000, CategoryId = mobilePhone.Id, ManufacturerId = samsung.Id},
                    new Product {Name = "Samsung Galaxy Fit 2", Price = 987000, Quantity = 20, Image = "https://i.imgur.com/fi3AVqg.png", CashbackPercent = 10, CashbackMaximumValue = 11, CategoryId = smartWatch.Id, ManufacturerId = samsung.Id},
                };
                await productRespository.InsertManyAsync(products);
            }
            
        }
    }
}
