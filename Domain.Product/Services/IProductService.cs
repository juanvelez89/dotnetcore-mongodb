using Domain.Product.DTO;
using Domain.Product.DTO.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Product.Services
{
    public interface IProductService
    {
        ResponseDTO<ProductDTO> CreateProductAsync(ProductDTO product);
        ResponseDTO<List<ProductDTO>> GetAllProducts(string brand);
        ProductDTO GetProductById(string id);
        long UpdateProduct(ProductDTO product);
        long DisableProduct(string id);
    }
}
