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

        void UpdateProduct(ProductsModel products);

        Task AddProduct(ProductsModel products);
        

       Task <IEnumerable<ProductsModel>> GetAllProducts();

        Task<ProductsModel> GetOneProduct(int id);
        
       Task Delete(int id);
        
            



    }
}
