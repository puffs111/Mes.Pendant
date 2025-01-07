using Volo.Abp.Modularity;

namespace Mes.Pendant;

[DependsOn(
    typeof(PendantApplicationModule),
    typeof(PendantDomainTestModule)
)]
public class PendantApplicationTestModule : AbpModule
{

}
