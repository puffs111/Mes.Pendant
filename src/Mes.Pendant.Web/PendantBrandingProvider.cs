using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using Mes.Pendant.Localization;

namespace Mes.Pendant.Web;

[Dependency(ReplaceServices = true)]
public class PendantBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<PendantResource> _localizer;

    public PendantBrandingProvider(IStringLocalizer<PendantResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
