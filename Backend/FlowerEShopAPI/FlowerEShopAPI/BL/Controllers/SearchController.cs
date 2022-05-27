using FlowerEShopAPI.BL.Controllers.Interfaces;
using FlowerEShopAPI.BL.Services.ServiceInterfaces;
using FlowerEShopAPI.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using static FlowerEShopAPI.BL.Models.Body;

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

        [HttpGet]
        [TypeFilter(typeof(LogInterceptor))]
        public async Task<IActionResult> Get([FromBody] SearchBody body)
        {
            var search = await _searchService.SearchShops(body.SearchQuery, body.PriceStart, body.PriceEnd, body.Status);
            return ReturnResponse(search);
        }

        public IActionResult ReturnResponse(object value)
        {
            return Ok(new { Response = value });
        }
    }
}
