using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpWebAppDemo;

[Dependency(ReplaceServices = true)]
public class AbpWebAppDemoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpWebAppDemo";
}
