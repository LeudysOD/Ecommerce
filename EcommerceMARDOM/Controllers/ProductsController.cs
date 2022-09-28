using EcommerceApplicationContracts.Services;
using EcommerceMARDOM.Request;
using Microsoft.AspNetCore.Mvc;
using Model.Modelss;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EcommerceMARDOM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IModelProductsService _productsService;

        public ProductsController(IModelProductsService modelProductsService)
        {
            _productsService = modelProductsService;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllProducts()
        {
            var entity =  _productsService.GetAll();
            return Ok(entity);

        }




        // GET api/<ProductsController>/5
        [HttpGet]
        [Route("GetOne/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _productsService.GetOne(id);

            return Ok(entity);
        }
        [HttpGet]
        [Route("GetOneBy/{ProductCode}")]
        public async Task<IActionResult> GetByCode(string ProductCode)
        {
            var entity = await _productsService.GetProductCode(ProductCode);

            return Ok(entity);
        }

        // POST api/<ProductsController>
        [HttpPost]
        [Route("Create")]
        public async Task <IActionResult> Post(AddRequest request)
        {
            var product = new Products
            {
                ProductName= request.ProductName,
                ProductCode=request.ProductCode,
                Price =request.Price,
                OnHand = request.OnHand
            };

            await _productsService.AddProduct(product);

            return Ok();

        }

        // PUT api/<ProductsController>/5
        [HttpPatch]
        [Route("Restock/{ProductCode}")]
        public async Task<IActionResult> Restock(string ProductCode, RestockRequest request)
        {
            await _productsService.UpdateStock(ProductCode, request.Stock);
            return Ok();
            
        }



        [HttpPatch]
        [Route("Edit/{ProductCode}")]
        public async Task<IActionResult> EditProduct(string ProductCode,EditRequest request) {
            await _productsService.UpdateProduct(ProductCode,request.ProductName,request.Price);

            return Ok();
        }
       
         
            

        

        // DELETE api/<ProductsController>/5
        [HttpDelete ("id")]
        
        public async Task<IActionResult> Delete(int id)
        {
            await _productsService.DeleteProduct(id);
            return Ok();



        }
    }
}
