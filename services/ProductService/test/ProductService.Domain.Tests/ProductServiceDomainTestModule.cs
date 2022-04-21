using ProductService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ProductService;

[DependsOn(
    typeof(ProductServiceEntityFrameworkCoreTestModule)
    )]
public class ProductServiceDomainTestModule : AbpModule
{

}
