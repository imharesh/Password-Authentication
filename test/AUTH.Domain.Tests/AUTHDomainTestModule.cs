using AUTH.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AUTH;

[DependsOn(
    typeof(AUTHEntityFrameworkCoreTestModule)
    )]
public class AUTHDomainTestModule : AbpModule
{

}
