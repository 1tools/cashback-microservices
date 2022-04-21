using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace ProductService.Entities
{
    public class Product: AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double CashbackPercent { get; set; }
        public double CashbackMaximumValue { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

    }
}
