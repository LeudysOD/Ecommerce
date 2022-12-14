using EcommerceDAContracts;
using EcommerceDAContracts.Entities;
using EcommerceDAContracts.Repository;
using Microsoft.EntityFrameworkCore;
using Model.Modelss;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDA.Repository
{
    public  class ModelProductsRepository:IModelProductsRepository
    {
        private readonly IEcommerceContext _context;

        public ModelProductsRepository(IEcommerceContext context)
        {
            _context = context;
        }

        public async Task UpdateProduct ( ProductsModel products)
        {
            _context.Products.Update(products);
           await  _context.SaveChangesAsync();
        }

        public async Task AddProduct(ProductsModel products)
        {
            await _context.Products.AddAsync(products);
            await _context.SaveChangesAsync();
        }

        public List<ProductsModel> GetAllProducts()
        {
           return  _context.Products.Select(x=>x).ToList();
        }   
        public async Task<ProductsModel> GetOneProduct(int id)
        {
           return await _context.Products.FindAsync(id);
        }   
        public async Task<ProductsModel> GetByProductCode(string ProductCode)
        {
            return _context.Products.Where(x => x.ProductCode == ProductCode).FirstOrDefault();
        }
        public async Task<ProductsModel> UpdateStock(string ProductCode,int Newstock)
        {
               var entity = _context.Products.Where(x => x.ProductCode == ProductCode).FirstOrDefault();
            entity.OnHand = Newstock;

            _context.Products.Update(entity);

            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<ProductsModel> UpdateProduct(string ProductCode, string Name, int Price)
        {
            var entity = _context.Products.Where(x => x.ProductCode == ProductCode).FirstOrDefault();
            entity.ProductName = Name;
            entity.Price= Price;

            _context.Products.Update(entity);

            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task Delete (int id)
        {

            var entity = await GetOneProduct(id);
             _context.Products.Remove(entity);
           await _context.SaveChangesAsync();
          
        }
    }
}
