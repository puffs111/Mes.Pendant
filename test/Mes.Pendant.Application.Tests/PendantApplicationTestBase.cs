using Volo.Abp.Modularity;

namespace Mes.Pendant;

public abstract class PendantApplicationTestBase<TStartupModule> : PendantTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
