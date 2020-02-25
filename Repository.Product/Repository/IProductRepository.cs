using Repository.Product.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Product.Repository
{
    public interface IProductRepository
    {
        Task<ProductEntity> CreateProductAsync(ProductEntity product);
        Task<IEnumerable<ProductEntity>> GetProductAsync(string brand);
        ProductEntity GetProductById(string id);
        Task<long> UpdateProductAsync(ProductEntity product);
        Task<long> DisableProductAsync(string id);
    }
}
