using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var database = client.GetDatabase("Learning");
            var collection = database.GetCollection<BsonDocument>("Test");
            var document = new BsonDocument
            {
                { "name","MongoDB" },
                { "type","Database"},
                { "count",1 },
                { "info",new BsonDocument{
                    { "x",203 },
                    { "y",102 }}
                }
            };

            collection.InsertOne(document);
            var count = collection.CountDocuments(new BsonDocument());
            var first = collection.Find(new BsonDocument()).FirstOrDefault();
            Console.WriteLine(count);
            Console.WriteLine(first);
            var cursor = collection.Find(new BsonDocument()).ToCursor();
            foreach(var item in cursor.ToEnumerable())
            {
                Console.WriteLine(item);
            }

            var filter = Builders<BsonDocument>.Filter.Gt("i", 50);
            var secondCursor = collection.Find(filter).ToCursor();
            foreach(var item2 in secondCursor.ToEnumerable())
            {
                Console.WriteLine(item2);
            }

            var projection = Builders<BsonDocument>.Projection.Exclude("_id");
            var three = collection.Find(new BsonDocument()).Project(projection).First();
            Console.WriteLine(three.ToString());

            var filter4 = Builders<BsonDocument>.Filter.Eq("count", 2);
            var update4 = Builders<BsonDocument>.Update.Set("count", 1);
            collection.UpdateOne(filter4, update4);
            Console.WriteLine(collection.Find(new BsonDocument()).FirstOrDefault());

            var filter5 = Builders<BsonDocument>.Filter.Eq("count", 1);
            var update5 = Builders<BsonDocument>.Update.Set("count", 2);
            var result = collection.UpdateMany(filter5, update5);
            Console.WriteLine(result);
            if (result.IsModifiedCountAvailable)
            {
                Console.WriteLine(result.ModifiedCount);
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
