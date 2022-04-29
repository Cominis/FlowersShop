#nullable disable
using FlowerEShopAPI.BL.Attributes;
using FlowerEShopAPI.BL.Controllers.Interfaces;
using FlowerEShopAPI.BL.Services.ServiceInterfaces;
using FlowerEShopAPI.DAL.Entities;
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
        [HttpGet]
        [TypeFilter(typeof(LogInterceptor))]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            var user = (User)HttpContext.Items["User"];
            var getShop = await _shopService.GetShop(user.Id.ToString());
            return ReturnResponse(getShop);
        }

        // PUT: api/Shops/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [AuthorizeAttribute]
        [HttpPut("{id}")]
        [TypeFilter(typeof(LogInterceptor))]
        public async Task<IActionResult> Put(string id, [FromBody] ShopBody body)
        {
            var user = (User)HttpContext.Items["User"];
            var updatedShop = await _shopService.UpdateShop(id, body.Name, body.Description, body.Location, user.Id.ToString());
            return ReturnResponse(updatedShop);
        }

        // POST: api/Shops
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [AuthorizeAttribute]
        [HttpPost]
        [TypeFilter(typeof(LogInterceptor))]
        public async Task<IActionResult> Post([FromBody] ShopBody body)
        {
            var user = (User)HttpContext.Items["User"];
            var createdShop = await _shopService.CreateShop(body.Name, body.Description, body.Location, user.Id.ToString());
            return ReturnResponse(createdShop);
        }

        // DELETE: api/Shops/5
        [AuthorizeAttribute]
        [HttpDelete("{id}")]
        [TypeFilter(typeof(LogInterceptor))]
        public async Task<IActionResult> Delete(string id)
        {
            var user = (User)HttpContext.Items["User"];
            await _shopService.DeleteShop(id, user.Id.ToString());
            return ReturnResponse("Shop was deleted successfully");
        }

        public IActionResult ReturnResponse(object value)
        {
            return Ok(new { Response = value });
        }
    }
}
