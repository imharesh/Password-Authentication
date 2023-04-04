using System.Threading.Tasks;

namespace AUTH.Data;

public interface IAUTHDbSchemaMigrator
{
    Task MigrateAsync();
}
