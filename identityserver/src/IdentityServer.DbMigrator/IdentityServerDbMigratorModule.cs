using IdentityServer.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace IdentityServer.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(IdentityServerEntityFrameworkCoreModule),
    typeof(IdentityServerApplicationContractsModule)
    )]
public class IdentityServerDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
