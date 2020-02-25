using AutoMapper;
using Domain.Product.DTO;
using Repository.Product.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Config.Product.Mappers
{
    public class ProductMapper:Profile
    {
        public ProductMapper()
        {
            CreateMap<ProductDTO, ProductEntity>().ReverseMap();
        }
    }
}
