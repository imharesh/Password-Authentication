using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AUTH.Data;

/* This is used if database provider does't define
 * IAUTHDbSchemaMigrator implementation.
 */
public class NullAUTHDbSchemaMigrator : IAUTHDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
