using Volo.Abp.Settings;

namespace Invengo.Library.MIS.Settings
{
    public class MISSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MISSettings.MySetting1));
        }
    }
}
