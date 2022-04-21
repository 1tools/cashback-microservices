using ProductService.Dtos;
using ProductService.Entities;
using ProductService.Repositories;
using System;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ProductService.Services
{
    public class CategoryAppService : CrudAppService<Category, CategoryDto, Guid>, ICategoryAppService
    {
        public CategoryAppService(IRepository<Category, Guid> repository) : base(repository)
        {

        }
    }
}
