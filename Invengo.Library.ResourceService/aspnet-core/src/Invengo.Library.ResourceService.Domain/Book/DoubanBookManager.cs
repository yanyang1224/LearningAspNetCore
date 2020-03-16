using Invengo.Library.ISBNUtility;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace Invengo.Library.ResourceService
{
    public class DoubanBookManager:DomainService, IDoubanBookManager
    {
        private static IMongoClient _mongoClient { get; set; }
        private static IMongoDatabase _mongoDatabase { get; set; }

        public DoubanBookManager(IConfiguration config)
        {
            var mongoUrl = new MongoUrl(config.GetConnectionString("MongoDB"));
            var databaseName = mongoUrl.DatabaseName;
            if(_mongoClient == null)
            {
                _mongoClient = new MongoClient(mongoUrl);
                _mongoDatabase = _mongoClient.GetDatabase(databaseName);
            }
        }

        public async Task<string> GetBookByISBN(string isbn)
        {
            var isbnUtility = new ISBN();
            isbn = isbn.Replace("-", "").Replace(" ", "").Replace(".", "").Replace("X", "x");
            var version = isbnUtility.GetISBNVersion(isbn);
            if (version == VERSION.INVALID) throw new UserFriendlyException("isbn is invalid.","2000");

            var filter = Builders<BsonDocument>.Filter.Eq("isbn13", isbn);
            if (version == VERSION.ISBN10)
            {
                filter = Builders<BsonDocument>.Filter.Eq("isbn10", isbn);
            }

            var projection = Builders<BsonDocument>.Projection.Exclude("_id");
            var document = await _mongoDatabase.GetCollection<BsonDocument>("ResDoubanBook").Find(filter).Project(projection).FirstOrDefaultAsync();
            if (document == null)
            {
                throw new UserFriendlyException("can't find document.", "2001");
            }
            return document.ToString();
        }

        public async Task GetImageByISBN(string isbn)
        {

        }
    }
}
