using ProductService.Dtos;
using System;
using Volo.Abp.Application.Services;

namespace ProductService.Services
{
    public interface ICategoryAppService: ICrudAppService<CategoryDto, Guid>
    {

    }
}
