using Microsoft.AspNetCore.Mvc;
using static FlowerEShopAPI.BL.Models.Body;

namespace FlowerEShopAPI.BL.Controllers.Interfaces
{
    public interface ISearchController
    {
        public Task<IActionResult> Get([FromBody] SearchBody body);
    }
}
