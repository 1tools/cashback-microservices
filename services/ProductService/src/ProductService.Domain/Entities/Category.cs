﻿using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace ProductService.Entities
{
    public class Category: Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
