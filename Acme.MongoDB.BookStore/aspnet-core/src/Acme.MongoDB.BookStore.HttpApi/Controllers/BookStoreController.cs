using Acme.MongoDB.BookStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.MongoDB.BookStore.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BookStoreController : AbpController
    {
        protected BookStoreController()
        {
            LocalizationResource = typeof(BookStoreResource);
        }
    }
}