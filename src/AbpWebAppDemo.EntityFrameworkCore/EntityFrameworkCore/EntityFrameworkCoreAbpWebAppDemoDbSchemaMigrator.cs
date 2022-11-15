using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpWebAppDemo.Data;
using Volo.Abp.DependencyInjection;

namespace AbpWebAppDemo.EntityFrameworkCore;

public class EntityFrameworkCoreAbpWebAppDemoDbSchemaMigrator
    : IAbpWebAppDemoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpWebAppDemoDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpWebAppDemoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpWebAppDemoDbContext>()
            .Database
            .MigrateAsync();
    }
}
