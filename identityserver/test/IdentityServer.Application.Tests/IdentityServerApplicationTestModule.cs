using Volo.Abp.Modularity;

namespace IdentityServer;

[DependsOn(
    typeof(IdentityServerApplicationModule),
    typeof(IdentityServerDomainTestModule)
    )]
public class IdentityServerApplicationTestModule : AbpModule
{

}
