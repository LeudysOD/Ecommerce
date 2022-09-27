using EcommerceDAContracts.Entities;
using Model.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplicationContracts.Mappers
{
    public class ProductModelMapper
    {

        public static Products Map(ProductsModel productsModel)
        {
            return new Products
            
                {
                    ProductId = productsModel.ProductId,
                    ProductName = productsModel.ProductName,
                    Price = productsModel.Price,
                    OnHand = productsModel.OnHand
                };
  
        }
    }
}
