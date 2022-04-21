using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace IdentityServer;

[Dependency(ReplaceServices = true)]
public class IdentityServerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "IdentityServer";
}
