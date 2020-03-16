using Volo.Abp.Settings;

namespace Invengo.Library.ResourceService.Settings
{
    public class ResourceServiceSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ResourceServiceSettings.MySetting1));
        }
    }
}
