using CashbackService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CashbackService;

[DependsOn(
    typeof(CashbackServiceEntityFrameworkCoreTestModule)
    )]
public class CashbackServiceDomainTestModule : AbpModule
{

}
