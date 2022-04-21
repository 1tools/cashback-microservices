using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace PaymentService;

[Dependency(ReplaceServices = true)]
public class PaymentServiceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PaymentService";
}
