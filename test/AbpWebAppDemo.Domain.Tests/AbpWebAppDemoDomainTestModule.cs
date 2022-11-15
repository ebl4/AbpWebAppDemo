using AbpWebAppDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpWebAppDemo;

[DependsOn(
    typeof(AbpWebAppDemoEntityFrameworkCoreTestModule)
    )]
public class AbpWebAppDemoDomainTestModule : AbpModule
{

}
