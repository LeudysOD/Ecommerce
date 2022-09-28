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
       

        Task AddProduct(Products products);

        Task UpdateProduct(Products products);


         Task DeleteProduct(int id);
        
    }
}
