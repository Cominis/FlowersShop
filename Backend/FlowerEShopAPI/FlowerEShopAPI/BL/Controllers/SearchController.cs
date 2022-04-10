using FlowerEShopAPI.BL.Controllers.Interfaces;
using FlowerEShopAPI.BL.Services.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace FlowerEShopAPI.BL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase, ISearchController
    {
        private readonly ISearchService _searchService;
        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet("{searchQuery}/{priceStart}/{priceEnd}/{status}")]
        [TypeFilter(typeof(LogInterceptor))]
        public async Task<IActionResult> Get(string searchQuery, decimal priceStart, decimal priceEnd, string status = "All")
        {
            var search = await _searchService.SearchShops(searchQuery, priceStart, priceEnd, status);
            return ReturnResponse(search);
        }

        public IActionResult ReturnResponse(object value)
        {
            return Ok(new { Response = value });
        }
    }
}
