using AbpWebAppDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpWebAppDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpWebAppDemoController : AbpControllerBase
{
    protected AbpWebAppDemoController()
    {
        LocalizationResource = typeof(AbpWebAppDemoResource);
    }
}
