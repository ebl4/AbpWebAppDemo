using System.Threading.Tasks;

namespace AbpWebAppDemo.Data;

public interface IAbpWebAppDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
