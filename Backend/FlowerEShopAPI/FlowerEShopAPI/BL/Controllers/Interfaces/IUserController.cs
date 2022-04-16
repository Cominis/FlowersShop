using Microsoft.AspNetCore.Mvc;
using static FlowerEShopAPI.BL.Models.Body;

namespace FlowerEShopAPI.BL.Controllers.Interfaces
{
    public interface IUserController
    {
        public Task<IActionResult> Post([FromBody] UserCred userCred);
        public Task<IActionResult> Put(string id, [FromBody] UserCred userCred);
        public Task<IActionResult> Get(string id);

    }
}
