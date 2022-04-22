#nullable disable
using FlowerEShopAPI.Services.ServiceInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static FlowerEShopAPI.BL.Models.Body;

namespace FlowerEShopAPI.BL.Controllers
{
    [Authorize]
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
        public async Task<IActionResult> Get(string id)
        {
            var product = await _productService.GetById(id);

            return ReturnResponse(product);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] ProductBody productBody)
        {
            var updatedProduct = await _productService.UpdateProduct(id, productBody.ShopId, productBody.Title, productBody.Description, productBody.Category, productBody.SubCategory, productBody.Status, productBody.Price, productBody.Quantity, HttpContext.User.Identity.Name);

            return ReturnResponse(updatedProduct);
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductBody productBody)
        {
            var createdProduct = await _productService.AddProductToShop(productBody.ShopId, productBody.Title, productBody.Description, productBody.Category, productBody.SubCategory, productBody.Status, productBody.Price, productBody.Quantity, HttpContext.User.Identity.Name);

            return ReturnResponse(createdProduct);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _productService.DeleteProduct(id, HttpContext.User.Identity.Name);

            return ReturnResponse("Product deleted successfully");
        }

        public IActionResult ReturnResponse(object value) => Ok(new { Response = value });
    }
}
