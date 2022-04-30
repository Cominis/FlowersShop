using Microsoft.AspNetCore.Mvc;
using static FlowerEShopAPI.BL.Models.Body;

namespace FlowerEShopAPI.BL.Controllers.Interfaces
{
    public interface IUserController
    {
        public Task<IActionResult> Post([FromBody] UserCred userCred);
        public Task<IActionResult> Put([FromBody] UserCred userCred);
        public Task<IActionResult> Get();
    }
}
