using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AUTH.Data;
using Volo.Abp.DependencyInjection;

namespace AUTH.EntityFrameworkCore;

public class EntityFrameworkCoreAUTHDbSchemaMigrator
    : IAUTHDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAUTHDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AUTHDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AUTHDbContext>()
            .Database
            .MigrateAsync();
    }
}
