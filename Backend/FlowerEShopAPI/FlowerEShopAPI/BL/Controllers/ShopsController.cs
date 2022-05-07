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
        private readonly ILogsService _logsService;

        public ShopsController(IShopService shopService, ILogsService logsService)
        {
            _shopService = shopService;
            _logsService = logsService;
        }

        // GET: api/Shops/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var user = (User)HttpContext.Items["User"];
            await _logsService.LogAction(user.UserName ?? "Guest", GetType().Name, "Get", "Finding shop");
            var getShop = await _shopService.GetShop(id);
            await _logsService.LogAction(user.UserName ?? "Guest", GetType().Name, "Get", "Shop found");
            return ReturnResponse(getShop);
        }

        // PUT: api/Shops/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [AuthorizeAttribute]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] ShopBody body)
        {
            var user = (User)HttpContext.Items["User"];
            await _logsService.LogAction(user.UserName, GetType().Name, "Put", "Updating shop");
            var updatedShop = await _shopService.UpdateShop(id, body.Name, body.Description, body.Location, user.Id.ToString());
            await _logsService.LogAction(user.UserName, GetType().Name, "Put", "Shop updated");
            return ReturnResponse(updatedShop);
        }

        // POST: api/Shops
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [AuthorizeAttribute]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ShopBody body)
        {
            var user = (User)HttpContext.Items["User"];
            await _logsService.LogAction(user.UserName, GetType().Name, "Create", "Creating shop");
            var createdShop = await _shopService.CreateShop(body.Name, body.Description, body.Location, user.Id.ToString());
            await _logsService.LogAction(user.UserName, GetType().Name, "Create", "Shop created");
            return ReturnResponse(createdShop);
        }

        // DELETE: api/Shops/5
        [AuthorizeAttribute]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var user = (User)HttpContext.Items["User"];
            await _logsService.LogAction(user.UserName, GetType().Name, "Delete", "Deleting shop with id: " + id);
            await _shopService.DeleteShop(id, user.Id.ToString());
            await _logsService.LogAction(user.UserName, GetType().Name, "Delete", "Shop with id: " + id + "deleted");
            return ReturnResponse("Shop was deleted successfully");
        }

        public IActionResult ReturnResponse(object value)
        {
            return Ok(new { Response = value });
        }
    }
}
