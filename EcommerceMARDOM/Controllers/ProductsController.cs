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
        public async Task<IActionResult> GetAllProducts()
        {
            var entity = _productsService.GetAll();
            return Ok(entity);
                
        }


        

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = _productsService.GetOne(id);

            return Ok(entity);
        }

        // POST api/<ProductsController>
        [HttpPost]
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
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
