using IdentityServer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace IdentityServer;

[DependsOn(
    typeof(IdentityServerEntityFrameworkCoreTestModule)
    )]
public class IdentityServerDomainTestModule : AbpModule
{

}
