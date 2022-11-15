using AbpWebAppDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpWebAppDemo.Permissions;

public class AbpWebAppDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpWebAppDemoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpWebAppDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpWebAppDemoResource>(name);
    }
}
