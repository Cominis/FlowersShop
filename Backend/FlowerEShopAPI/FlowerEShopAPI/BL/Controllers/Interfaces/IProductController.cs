using Microsoft.AspNetCore.Mvc;
using static FlowerEShopAPI.BL.Models.Body;

namespace FlowerEShopAPI.BL.Controllers.Interfaces
{
    public interface IProductController
    {
        public Task<IActionResult> Get(string id);
        public Task<IActionResult> Put(string id, [FromBody] ProductBody productBody);
        public Task<IActionResult> Post([FromBody] ProductBody productBody);
        public Task<IActionResult> Delete(string id);
    }
}
