using Volo.Abp.Modularity;

namespace CashbackService;

[DependsOn(
    typeof(CashbackServiceApplicationModule),
    typeof(CashbackServiceDomainTestModule)
    )]
public class CashbackServiceApplicationTestModule : AbpModule
{

}
