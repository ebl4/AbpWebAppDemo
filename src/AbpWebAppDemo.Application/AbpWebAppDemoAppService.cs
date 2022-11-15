using System;
using System.Collections.Generic;
using System.Text;
using AbpWebAppDemo.Localization;
using Volo.Abp.Application.Services;

namespace AbpWebAppDemo;

/* Inherit your application services from this class.
 */
public abstract class AbpWebAppDemoAppService : ApplicationService
{
    protected AbpWebAppDemoAppService()
    {
        LocalizationResource = typeof(AbpWebAppDemoResource);
    }
}
