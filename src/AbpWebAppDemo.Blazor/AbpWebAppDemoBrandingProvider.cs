using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpWebAppDemo.Blazor;

[Dependency(ReplaceServices = true)]
public class AbpWebAppDemoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpWebAppDemo";
}
