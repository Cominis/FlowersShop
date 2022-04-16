using Microsoft.AspNetCore.Mvc;
using static FlowerEShopAPI.BL.Models.Body;

namespace FlowerEShopAPI.BL.Controllers.Interfaces
{
    public interface IShopController
    {
        public Task<IActionResult> Get(string id);
        public Task<IActionResult> Post([FromBody] ShopBody body);
        public Task<IActionResult> Put(string id, [FromBody] ShopBody body);
        public Task<IActionResult> Delete(string id);
    }
}
