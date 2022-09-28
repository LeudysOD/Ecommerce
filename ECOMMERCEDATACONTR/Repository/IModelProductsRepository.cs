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

    

        Task AddProduct(ProductsModel products);


        List<ProductsModel> GetAllProducts();

        Task<ProductsModel> GetOneProduct(int id);

        Task<ProductsModel> GetByProductCode(string ProductCode);
        Task<ProductsModel> UpdateStock(string ProductCode, int Newstock);
        Task<ProductsModel> UpdateProduct(string ProductCode, string Name, int Price);

        Task Delete(int id);






    }
}
