using Volo.Abp.Modularity;

namespace AbpWebAppDemo;

[DependsOn(
    typeof(AbpWebAppDemoApplicationModule),
    typeof(AbpWebAppDemoDomainTestModule)
    )]
public class AbpWebAppDemoApplicationTestModule : AbpModule
{

}
