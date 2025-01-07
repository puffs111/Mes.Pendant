using Volo.Abp.Modularity;

namespace Mes.Pendant;

[DependsOn(
    typeof(PendantDomainModule),
    typeof(PendantTestBaseModule)
)]
public class PendantDomainTestModule : AbpModule
{

}
