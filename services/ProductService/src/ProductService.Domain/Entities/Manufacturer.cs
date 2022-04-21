using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace ProductService.Entities
{
    public class Manufacturer: Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
