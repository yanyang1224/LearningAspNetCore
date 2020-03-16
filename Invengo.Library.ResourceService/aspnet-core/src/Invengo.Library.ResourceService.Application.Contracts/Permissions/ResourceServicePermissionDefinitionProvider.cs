using Invengo.Library.ResourceService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Invengo.Library.ResourceService.Permissions
{
    public class ResourceServicePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ResourceServicePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ResourceServicePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ResourceServiceResource>(name);
        }
    }
}
