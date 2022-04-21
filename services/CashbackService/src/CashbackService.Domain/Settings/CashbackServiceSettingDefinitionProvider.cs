using Volo.Abp.Settings;

namespace CashbackService.Settings;

public class CashbackServiceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CashbackServiceSettings.MySetting1));
    }
}
