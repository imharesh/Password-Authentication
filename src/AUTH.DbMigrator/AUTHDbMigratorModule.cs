using AUTH.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AUTH.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AUTHEntityFrameworkCoreModule),
    typeof(AUTHApplicationContractsModule)
    )]
public class AUTHDbMigratorModule : AbpModule
{

}
