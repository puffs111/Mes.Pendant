using Volo.Abp.Settings;

namespace Mes.Pendant.Settings;

public class PendantSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PendantSettings.MySetting1));
    }
}
