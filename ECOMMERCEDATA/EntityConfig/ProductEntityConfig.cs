using EcommerceDAContracts.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMMERCEDATA.EntityConfig
{
    public class ProductEntityConfig
    {

        public static void SetProductEntityConfig(EntityTypeBuilder<ProductsModel> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.ProductId);
           
        }
    }
}
