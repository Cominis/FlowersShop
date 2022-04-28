#nullable disable
using FlowerEShopAPI.BL.Controllers.Interfaces;
using FlowerEShopAPI.Services.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using static FlowerEShopAPI.BL.Models.Body;

namespace FlowerEShopAPI.BL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopsController : ControllerBase, IShopController
    {
        private readonly IShopService _shopService;

        public ShopsController(IShopService shopService)
        {
            _shopService = shopService;
        }

        // GET: api/Shops/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var getShop = await _shopService.GetShop(id);

            return ReturnResponse(getShop);
        }

        // PUT: api/Shops/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] ShopBody body)
        {
            var updatedShop = await _shopService.UpdateShop(id, body.Name, body.Description, body.Location, HttpContext.User.Identity.Name);

            return ReturnResponse(updatedShop);
        }

        // POST: api/Shops
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ShopBody body)
        {
            var createdShop = await _shopService.CreateShop(body.Name, body.Description, body.Location, body.UserId);

            return ReturnResponse(createdShop);
        }

        // DELETE: api/Shops/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _shopService.DeleteShop(id, HttpContext.User.Identity.Name);

            return ReturnResponse("Shop was deleted successfully");
        }

        public IActionResult ReturnResponse(object value)
        {
            return Ok(new { Response = value });
        }
    }
}
