using AbpWebAppDemo.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpWebAppDemo.Blazor;

public abstract class AbpWebAppDemoComponentBase : AbpComponentBase
{
    protected AbpWebAppDemoComponentBase()
    {
        LocalizationResource = typeof(AbpWebAppDemoResource);
    }
}
