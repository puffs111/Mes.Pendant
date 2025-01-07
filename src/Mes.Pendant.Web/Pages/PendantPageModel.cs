using Mes.Pendant.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Mes.Pendant.Web.Pages;

public abstract class PendantPageModel : AbpPageModel
{
    protected PendantPageModel()
    {
        LocalizationResourceType = typeof(PendantResource);
    }
}
