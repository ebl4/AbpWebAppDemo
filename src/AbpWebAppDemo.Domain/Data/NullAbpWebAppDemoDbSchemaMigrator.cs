using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpWebAppDemo.Data;

/* This is used if database provider does't define
 * IAbpWebAppDemoDbSchemaMigrator implementation.
 */
public class NullAbpWebAppDemoDbSchemaMigrator : IAbpWebAppDemoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
