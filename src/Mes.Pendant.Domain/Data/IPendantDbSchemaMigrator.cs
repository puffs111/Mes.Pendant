using System.Threading.Tasks;

namespace Mes.Pendant.Data;

public interface IPendantDbSchemaMigrator
{
    Task MigrateAsync();
}
