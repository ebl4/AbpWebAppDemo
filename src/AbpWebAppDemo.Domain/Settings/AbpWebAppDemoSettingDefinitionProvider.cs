using Volo.Abp.Settings;

namespace AbpWebAppDemo.Settings;

public class AbpWebAppDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpWebAppDemoSettings.MySetting1));
    }
}
