using PaymentService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace PaymentService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PaymentServiceEntityFrameworkCoreModule),
    typeof(PaymentServiceApplicationContractsModule)
    )]
public class PaymentServiceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
