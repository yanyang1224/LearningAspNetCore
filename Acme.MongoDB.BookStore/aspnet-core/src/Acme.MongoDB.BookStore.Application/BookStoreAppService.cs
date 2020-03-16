using System;
using System.Collections.Generic;
using System.Text;
using Acme.MongoDB.BookStore.Localization;
using Volo.Abp.Application.Services;

namespace Acme.MongoDB.BookStore
{
    /* Inherit your application services from this class.
     */
    public abstract class BookStoreAppService : ApplicationService
    {
        protected BookStoreAppService()
        {
            LocalizationResource = typeof(BookStoreResource);
        }
    }
}
