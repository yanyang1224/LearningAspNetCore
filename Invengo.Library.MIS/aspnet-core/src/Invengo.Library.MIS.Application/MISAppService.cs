using System;
using System.Collections.Generic;
using System.Text;
using Invengo.Library.MIS.Localization;
using Volo.Abp.Application.Services;

namespace Invengo.Library.MIS
{
    /* Inherit your application services from this class.
     */
    public abstract class MISAppService : ApplicationService
    {
        protected MISAppService()
        {
            LocalizationResource = typeof(MISResource);
        }
    }
}
