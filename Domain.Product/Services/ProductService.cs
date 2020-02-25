using System;
using System.Collections.Generic;
using System.Text;
using Domain.Product.DTO;
using Domain.Product.DTO.ResponseDTO;
using Repository.Product.Repository;
using AutoMapper;
using Repository.Product.Entities;
using MongoDB.Bson;

namespace Domain.Product.Services
{
    public class ProductService : IProductService
    {
        protected IProductRepository _productRepository;
        private IMapper _mapper;

        public ProductService()
        {
        }

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _productRepository = repository;
            _mapper = mapper;
        }
        public ResponseDTO<ProductDTO> CreateProductAsync(ProductDTO product)
        {
            var productEntity = new ProductEntity();
           productEntity = _mapper.Map<ProductEntity>(product);
            _productRepository.CreateProductAsync(productEntity);
            return product.AsResponse<ProductDTO>(200, "");
        }

        public long DisableProduct(string id)
        {
            var disableProduct = _productRepository.DisableProductAsync(id);
            return disableProduct.Result;
        }

        public ResponseDTO<List<ProductDTO>> GetAllProducts(string brand)
        {
            var products = _productRepository.GetProductAsync(brand).Result;
            var productDto = new List<ProductDTO>();
            productDto = _mapper.Map<List<ProductDTO>>(products);
            return productDto.AsResponse<List<ProductDTO>>(200, "");
        }

        public ProductDTO GetProductById(string id)
        {
            var product = new ProductDTO();
            var productEntity = _productRepository.GetProductById(id);
            product = _mapper.Map<ProductDTO>(productEntity);
            return product;
        }

        public long UpdateProduct(ProductDTO product)
        {
            var productEntity = new ProductEntity();
            var product_id = new BsonObjectId(ObjectId.Parse(product._Id));
            var company_id = new BsonObjectId(ObjectId.Parse(product.Brand.Company._Id));
            var brand_id = new BsonObjectId(ObjectId.Parse(product.Brand._Id));
            productEntity = _mapper.Map<ProductEntity>(product);
            productEntity._Id = product_id.AsObjectId;
            productEntity.Brand.Company._Id = company_id.AsObjectId;
            productEntity.Brand._Id = brand_id.AsObjectId;
            var updateCount = _productRepository.UpdateProductAsync(productEntity);
            return updateCount.Result;
        }
    }
}
