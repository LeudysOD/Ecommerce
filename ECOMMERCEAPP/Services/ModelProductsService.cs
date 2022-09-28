

using EcommerceApplicationContracts.Mappers;
using EcommerceApplicationContracts.Services;
using EcommerceDAContracts.Entities;
using EcommerceDAContracts.Mapper;
using EcommerceDAContracts.Repository;
using Model.Modelss;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EcommerceApplication.Services
{
    public class ModelProductsService : IModelProductsService
    {

        private readonly IModelProductsRepository _modelProductsRepository;

        public ModelProductsService(IModelProductsRepository modelProductsRepository)
        {
            _modelProductsRepository = modelProductsRepository;
        }

        public List<ProductsModel> GetAll()
        {
             var entity = _modelProductsRepository.GetAllProducts();
            return entity;
           
        }
        public async Task<Products> GetOne(int id)
        {
            var entity = await _modelProductsRepository.GetOneProduct(id);

            return ProductModelMapper.Map(entity);
            
        }

        public async Task AddProduct(Products products)
        {
            await _modelProductsRepository.AddProduct(ProductEntityMapper.Map(products));
        }
        public async Task UpdateProduct(Products products)
        {
           await  _modelProductsRepository.UpdateProduct(ProductEntityMapper.Map(products));
        }

        public async Task DeleteProduct(int id)
        {
            await _modelProductsRepository.Delete(id);
        }
    }
}
