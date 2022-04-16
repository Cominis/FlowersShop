using Microsoft.AspNetCore.Mvc;
using static FlowerEShopAPI.BL.Models.Body;

namespace FlowerEShopAPI.BL.Controllers.Interfaces
{
    public interface IShoppingcartController
    {
        public Task<IActionResult> Get(string id);
        public Task<IActionResult> Post([FromBody] ShoppingCartBody shoppingCartBody);
        public Task<IActionResult> DeleteShoppingCart(string id, [FromBody] ShoppingCartBody shoppingCartBody);
    }
}
