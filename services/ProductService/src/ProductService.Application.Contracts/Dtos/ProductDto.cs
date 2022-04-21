using System;
using Volo.Abp.Application.Dtos;

namespace ProductService.Dtos
{
    public class ProductDto: AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double CashbackPercent { get; set; }
        public double CashbackMaximumValue { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }

        public CategoryDto Category { get; set; }
        public ManufacturerDto Manufacturer { get; set; }
    }
}
