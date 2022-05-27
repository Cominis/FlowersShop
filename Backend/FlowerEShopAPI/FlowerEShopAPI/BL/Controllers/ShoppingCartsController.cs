#nullable disable
using FlowerEShopAPI.BL.Attributes;
using FlowerEShopAPI.BL.Controllers.Interfaces;
using FlowerEShopAPI.BL.Services.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using static FlowerEShopAPI.BL.Models.Body;

namespace FlowerEShopAPI.BL.Controllers
{
    [AuthorizeAttribute]
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartsController : ControllerBase, IShoppingcartController
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartsController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        // GET: api/ShoppingCarts/5
        [HttpGet("{id}")]
        [TypeFilter(typeof(LogInterceptor))]
        public async Task<IActionResult> Get(string id)
        {
            var shoppingCart = await _shoppingCartService.GetShoppingCart(id);

            return ReturnResponse(shoppingCart);
        }

        // POST: api/ShoppingCarts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [TypeFilter(typeof(LogInterceptor))]
        public async Task<IActionResult> Post([FromBody] ShoppingCartBody shoppingCartBody)
        {
            var shoppingCart = await _shoppingCartService.AddToCart(shoppingCartBody.ProductId, shoppingCartBody.Quantity, shoppingCartBody.UserId);

            return ReturnResponse(shoppingCart);
        }

        // DELETE: api/ShoppingCarts/5
        [HttpDelete("{id}")]
        [TypeFilter(typeof(LogInterceptor))]
        public async Task<IActionResult> Delete(string id, [FromBody] ShoppingCartBody shoppingCartBody)
        {
            await _shoppingCartService.RemoveFromCart(id, shoppingCartBody.UserId);

            return ReturnResponse("ShoppingCart item was deleted successfully");
        }

        public IActionResult ReturnResponse(object value)
        {
            return Ok(new { Response = value });
        }
    }
}
