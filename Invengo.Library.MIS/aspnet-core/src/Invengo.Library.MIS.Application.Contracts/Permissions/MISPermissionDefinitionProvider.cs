using Invengo.Library.MIS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Invengo.Library.MIS.Permissions
{
    public class MISPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MISPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(MISPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MISResource>(name);
        }
    }
}
