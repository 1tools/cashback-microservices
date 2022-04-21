using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CashbackService;

[Dependency(ReplaceServices = true)]
public class CashbackServiceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CashbackService";
}
