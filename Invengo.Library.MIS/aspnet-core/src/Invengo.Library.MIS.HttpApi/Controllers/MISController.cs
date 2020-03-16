using Invengo.Library.MIS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Invengo.Library.MIS.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MISController : AbpController
    {
        protected MISController()
        {
            LocalizationResource = typeof(MISResource);
        }
    }
}