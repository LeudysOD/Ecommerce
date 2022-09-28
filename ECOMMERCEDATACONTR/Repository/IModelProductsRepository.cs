using EcommerceDAContracts.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDAContracts.Repository
{
     public interface IModelProductsRepository
    {

        Task UpdateProduct(ProductsModel products);

        Task AddProduct(ProductsModel products);


        List<ProductsModel> GetAllProducts();

        Task<ProductsModel> GetOneProduct(int id);

        Task Delete(int id);






    }
}
