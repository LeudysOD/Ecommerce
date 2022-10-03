using EcommerceDAContracts.Entities;
using Model.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDAContracts.Mapper
{
    public  class ProductEntityMapper
    {

        public static ProductsModel Map(Products products)
        {
            return new ProductsModel
            {
                ProductId = (int)products.ProductId,
                ProductCode = products.ProductCode, 
                ProductName = products.ProductName,
                Price = (double)products.Price,
                OnHand = (int)products.OnHand
            };
        }
    }
}
