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
        [Route("GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var entity = _productsService.GetAll();
            return Ok(entity);

        }




        // GET api/<ProductsController>/5
        [HttpGet]
        [Route("GetOneProduct/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _productsService.GetOne(id);

            return Ok(entity);
        }

        // POST api/<ProductsController>
        [HttpPost]
        [Route("CreateProduct")]
        public async Task <IActionResult> Post(AddRequest request)
        {
            var product = new Products
            {
                ProductName= request.ProductName,
                Price =request.Price,
                OnHand = request.OnHand
            };

            await _productsService.AddProduct(product);

            return Ok();

        }

        // PUT api/<ProductsController>/5
        [HttpPatch]
        [Route("Restock/{id}")]
        public async Task<IActionResult> Restock(int id, RestockRequest request)
        {

            var entity = await _productsService.GetOne(id);
            entity.OnHand = 30;

           await _productsService.UpdateProduct(entity);
            
         

            return Ok();
            
        }



        [HttpPatch]
        [Route("Edit/{id}")]
        public async Task<IActionResult> EditProduct(int id,EditRequest request) {



           

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
