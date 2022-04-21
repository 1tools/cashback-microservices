using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ProductService;

[Dependency(ReplaceServices = true)]
public class ProductServiceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProductService";
}
