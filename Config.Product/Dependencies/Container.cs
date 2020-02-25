using AutoMapper;
using Domain.Product.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Product.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Config.Product.Dependencies
{
    public class Container
    {
        
        public static void Register(IServiceCollection service, IConfiguration configuration)

        {

            #region services
            service.AddScoped<IProductService, ProductService>();
            #endregion

            #region repository
            service.AddScoped<IProductRepository, ProductRepository>();
            #endregion

            #region autoMapper
            service.AddAutoMapper();
            #endregion

        }
    }
}
