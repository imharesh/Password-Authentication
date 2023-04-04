using AUTH.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AUTH.Permissions;

public class AUTHPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AUTHPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AUTHPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AUTHResource>(name);
    }
}
