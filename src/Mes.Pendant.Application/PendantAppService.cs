using Mes.Pendant.Localization;
using Volo.Abp.Application.Services;

namespace Mes.Pendant;

/* Inherit your application services from this class.
 */
public abstract class PendantAppService : ApplicationService
{
    protected PendantAppService()
    {
        LocalizationResource = typeof(PendantResource);
    }
}
