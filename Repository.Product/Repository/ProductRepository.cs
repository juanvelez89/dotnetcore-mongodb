using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Commons.Product.Classes.Mongo;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using Repository.Product.Entities;

namespace Repository.Product.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MongoContext _context = null;

        public ProductRepository(IOptions<MongoSettings> settings)
        {
            _context = new MongoContext(settings);
        }

        public async Task<ProductEntity> CreateProductAsync(ProductEntity product)
        {
            try
            {
                await _context.Products.InsertOneAsync(product);
                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<long> DisableProductAsync(string id)
        {
            var query_id = new BsonObjectId(ObjectId.Parse(id));
            var product = _context.Products.Find(x => x._Id.Equals(query_id)).FirstOrDefault();
            product.Status = false;
            var filter = Builders<ProductEntity>.Filter.Eq(s => s._Id, product._Id);
            var result = await _context.Products.ReplaceOneAsync(filter, product);
            return result.ModifiedCount;
        }

        public ProductEntity GetProductById(string id)
        {
            try
            {
                var query_id = new BsonObjectId(ObjectId.Parse(id));
                var product = _context.Products.Find(x => x._Id.Equals(query_id)).FirstOrDefault();
                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<ProductEntity>> GetProductAsync(string brand)
        {
            try
            {

                var products = await _context.Products.Find(x => x.Status == true && string.Equals(x.Brand.Name,brand)).ToListAsync();
                return products;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<long> UpdateProductAsync(ProductEntity product)
        {
            try
            {
                var filter = Builders<ProductEntity>.Filter.Eq(s => s._Id, product._Id);
                var result = await _context.Products.ReplaceOneAsync(filter, product);
                return result.ModifiedCount;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
