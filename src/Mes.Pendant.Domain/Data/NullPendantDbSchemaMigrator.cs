using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Mes.Pendant.Data;

/* This is used if database provider does't define
 * IPendantDbSchemaMigrator implementation.
 */
public class NullPendantDbSchemaMigrator : IPendantDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
