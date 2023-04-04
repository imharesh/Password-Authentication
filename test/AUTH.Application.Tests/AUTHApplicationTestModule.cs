using Volo.Abp.Modularity;

namespace AUTH;

[DependsOn(
    typeof(AUTHApplicationModule),
    typeof(AUTHDomainTestModule)
    )]
public class AUTHApplicationTestModule : AbpModule
{

}
