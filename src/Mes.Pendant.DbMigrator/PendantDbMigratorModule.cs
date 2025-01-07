using Mes.Pendant.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Mes.Pendant.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PendantEntityFrameworkCoreModule),
    typeof(PendantApplicationContractsModule)
)]
public class PendantDbMigratorModule : AbpModule
{
}
