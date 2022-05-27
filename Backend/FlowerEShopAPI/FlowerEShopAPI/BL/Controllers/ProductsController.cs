#nullable disable
using FlowerEShopAPI.BL.Attributes;
using FlowerEShopAPI.BL.Services.ServiceInterfaces;
using FlowerEShopAPI.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using static FlowerEShopAPI.BL.Models.Body;

namespace FlowerEShopAPI.BL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        [TypeFilter(typeof(LogInterceptor))]
        public async Task<IActionResult> Get(string id)
        {
            var user = (User)HttpContext.Items["User"];
            var product = await _productService.GetById(id);
            return ReturnResponse(product);
        }

        [TypeFilter(typeof(LogInterceptor))]
        [HttpGet]
        public async Task<IActionResult> GetAll([FromBody] AllProductsBody productBody)
        {
            var products = await _productService.GetAllProducts(productBody.ShopId, productBody.SortingItem);
            return ReturnResponse(products);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [AuthorizeAttribute]
        [HttpPut("{id}")]
        [TypeFilter(typeof(LogInterceptor))]
        public async Task<IActionResult> Put(string id, [FromBody] ProductBody productBody)
        {
            var user = (User)HttpContext.Items["User"];
            var updatedProduct = await _productService.UpdateProduct(id, productBody.ShopId, productBody.Title, productBody.Description, productBody.Category, productBody.SubCategory, productBody.Status, productBody.Price, productBody.Quantity, user.Id.ToString());
            return ReturnResponse(updatedProduct);
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [AuthorizeAttribute]
        [HttpPost]
        [TypeFilter(typeof(LogInterceptor))]
        public async Task<IActionResult> Post([FromBody] ProductBody productBody)
        {
            var user = (User)HttpContext.Items["User"];
            var createdProduct = await _productService.AddProductToShop(productBody.ShopId, productBody.Title, productBody.Description, productBody.Category, productBody.SubCategory, productBody.Status, productBody.Price, productBody.Quantity, user.Id.ToString());
            return ReturnResponse(createdProduct);
        }

        // DELETE: api/Products/5
        [AuthorizeAttribute]
        [HttpDelete("{id}")]
        [TypeFilter(typeof(LogInterceptor))]
        public async Task<IActionResult> Delete(string id)
        {
            var user = (User)HttpContext.Items["User"];
            await _productService.DeleteProduct(id, user.Id.ToString());
            return ReturnResponse("Product deleted successfully");
        }

        public IActionResult ReturnResponse(object value)
        {
            return Ok(new { Response = value });
        }
    }
}
