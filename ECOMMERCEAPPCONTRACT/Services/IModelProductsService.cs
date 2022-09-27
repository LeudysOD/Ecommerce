using EcommerceApplicationContracts.Mappers;
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

        Task GetAll();
     
        Task<Products> GetOne(int id);
       

        Task AddProduct(Products products);

        Task UpdateProduct(Products products);


         Task DeleteProduct(int id);
        
    }
}
