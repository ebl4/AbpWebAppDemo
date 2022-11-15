using AbpWebAppDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpWebAppDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpWebAppDemoEntityFrameworkCoreModule),
    typeof(AbpWebAppDemoApplicationContractsModule)
    )]
public class AbpWebAppDemoDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
