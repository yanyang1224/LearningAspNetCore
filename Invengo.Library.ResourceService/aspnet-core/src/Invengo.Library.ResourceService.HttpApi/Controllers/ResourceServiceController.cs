using Invengo.Library.ResourceService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Invengo.Library.ResourceService.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ResourceServiceController : AbpController
    {
        protected ResourceServiceController()
        {
            LocalizationResource = typeof(ResourceServiceResource);
        }
    }
}