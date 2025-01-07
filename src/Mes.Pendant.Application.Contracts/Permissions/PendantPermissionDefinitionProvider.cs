using Mes.Pendant.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Mes.Pendant.Permissions;

public class PendantPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PendantPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(PendantPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PendantResource>(name);
    }
}
