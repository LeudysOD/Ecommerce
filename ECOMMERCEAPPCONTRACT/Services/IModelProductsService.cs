using EcommerceApplicationContracts.Mappers;
using EcommerceDAContracts.Entities;
using EcommerceDAContracts.Mapper;
using Model.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplicationContracts.Services
{
    public interface IModelProductsService
    {

        List<ProductsModel> GetAll();


        Task<Products> GetOne(int id);

        Task<Products> GetProductCode(string ProductCode);

        Task AddProduct(Products products);

        Task UpdateStock(string ProductCode, int Newstock);
        Task UpdateProduct(string ProductCode, string Name, int Price);

         Task DeleteProduct(int id);
        
    }
}
