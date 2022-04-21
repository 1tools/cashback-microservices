using ProductService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ProductService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProductServiceEntityFrameworkCoreModule),
    typeof(ProductServiceApplicationContractsModule)
    )]
public class ProductServiceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
