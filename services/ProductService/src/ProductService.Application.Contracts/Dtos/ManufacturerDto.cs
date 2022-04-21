using System;
using Volo.Abp.Application.Dtos;

namespace ProductService.Dtos
{
    public class ManufacturerDto: AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
    }
}
