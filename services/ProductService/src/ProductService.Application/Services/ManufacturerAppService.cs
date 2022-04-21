using ProductService.Dtos;
using ProductService.Entities;
using System;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ProductService.Services
{
    public class ManufacturerAppService : CrudAppService<Manufacturer, ManufacturerDto, Guid>, IManufacturerAppService
    {
        public ManufacturerAppService(IRepository<Manufacturer, Guid> repository) : base(repository)
        {
        }
    }
}
