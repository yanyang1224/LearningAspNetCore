using MongoDB.Driver;
using Invengo.Library.ResourceService.Users;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Invengo.Library.ResourceService.MongoDB
{
    [ConnectionStringName("MongoDB")]
    public class ResourceServiceMongoDbContext : AbpMongoDbContext
    {
        public IMongoCollection<DoubanBook> DoubanBooks => Collection<DoubanBook>();

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.Entity<DoubanBook>(b =>
            {
                /* Sharing the same "AbpUsers" collection
                 * with the Identity module's IdentityUser class. */
                b.CollectionName = "DoubanBook";
            });
        }
    }
}
