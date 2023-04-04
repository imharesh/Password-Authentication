using Volo.Abp.Settings;

namespace AUTH.Settings;

public class AUTHSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AUTHSettings.MySetting1));
    }
}
