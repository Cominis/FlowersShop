using Microsoft.AspNetCore.Mvc;

namespace FlowerEShopAPI.BL.Controllers.Interfaces
{
    public interface ISearchController
    {
        public Task<IActionResult> Get(string searchQuery, decimal priceStart, decimal priceEnd, string status = "All");
    }
}
