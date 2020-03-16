using System;
using System.Collections.Generic;
using System.Text;
using Invengo.Library.ResourceService.Localization;
using Volo.Abp.Application.Services;

namespace Invengo.Library.ResourceService
{
    /* Inherit your application services from this class.
     */
    public abstract class ResourceServiceAppService : ApplicationService
    {
        protected ResourceServiceAppService()
        {
            LocalizationResource = typeof(ResourceServiceResource);
        }
    }
}
