using CashbackService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CashbackService.Permissions;

public class CashbackServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CashbackServicePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CashbackServicePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CashbackServiceResource>(name);
    }
}
