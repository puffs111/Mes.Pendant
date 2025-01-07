using Mes.Pendant.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Mes.Pendant.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PendantController : AbpControllerBase
{
    protected PendantController()
    {
        LocalizationResource = typeof(PendantResource);
    }
}
