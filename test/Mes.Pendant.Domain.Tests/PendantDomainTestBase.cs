using Volo.Abp.Modularity;

namespace Mes.Pendant;

/* Inherit from this class for your domain layer tests. */
public abstract class PendantDomainTestBase<TStartupModule> : PendantTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
