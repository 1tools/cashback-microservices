using CashbackService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CashbackService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CashbackServiceEntityFrameworkCoreModule),
    typeof(CashbackServiceApplicationContractsModule)
    )]
public class CashbackServiceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
