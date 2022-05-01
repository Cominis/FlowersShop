﻿#nullable disable
using FlowerEShopAPI.Services.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using static FlowerEShopAPI.BL.Models.Body;

namespace FlowerEShopAPI.BL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogsService _logsService;
        public ProductsController(IProductService productService, ILogsService logsService)
        {
            _productService = productService;
            _logsService = logsService;
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var product = await _productService.GetById(id);
            await _logsService.LogAction(product.Shop.User.UserName, GetType().Name, "Get", "Product found");
            return ReturnResponse(product);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] ProductBody productBody)
        {
            var updatedProduct = await _productService.UpdateProduct(id, productBody.ShopId, productBody.Title, productBody.Description, productBody.Category, productBody.SubCategory, productBody.Status, productBody.Price, productBody.Quantity, HttpContext.User.Identity.Name);
            await _logsService.LogAction(updatedProduct.Shop.User.UserName, GetType().Name, "Put", "Product updated");
            return ReturnResponse(updatedProduct);
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProductBody productBody)
        {
            var createdProduct = await _productService.AddProductToShop(productBody.ShopId, productBody.Title, productBody.Description, productBody.Category, productBody.SubCategory, productBody.Status, productBody.Price, productBody.Quantity, productBody.UserId);
            await _logsService.LogAction(createdProduct.Shop.User.UserName, GetType().Name, "Post", "Product created");
            return ReturnResponse(createdProduct);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var product = await _productService.GetById(id);
            await _productService.DeleteProduct(id, HttpContext.User.Identity.Name);
            await _logsService.LogAction(product.Shop.User.UserName, GetType().Name, "Delete", "Product with id: " + id + "deleted");
            return ReturnResponse("Product deleted successfully");
        }

        public IActionResult ReturnResponse(object value)
        {
            return Ok(new { Response = value });
        }
    }
}
