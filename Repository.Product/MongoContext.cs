using MongoDB.Driver;
using Repository.Product.Entities;
using Microsoft.Extensions.Options;
using System;
using Commons.Product.Classes.Mongo;

namespace Repository.Product
{
    public class MongoContext
    {
        private readonly IMongoDatabase _database = null;

        public MongoContext(IOptions<MongoSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(settings.Value.Database);
            }

        }

        public IMongoCollection<Entities.ProductEntity> Products
        {
            get
            {
                return _database.GetCollection<ProductEntity>("products");
            }
        }
    }
}
