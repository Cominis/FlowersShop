using FlowerEShopAPI.BL.Controllers.Interfaces;
using FlowerEShopAPI.Services.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using static FlowerEShopAPI.BL.Models.Body;

namespace FlowerEShopAPI.BL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase, ISearchController
    {
        private readonly ISearchService _searchService;
        public SearchController(ISearchService searchService, ILogsService logsService)
        {
            _searchService = searchService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromBody] SearchBody body)
        {
            var search = await _searchService.SearchShops(body.SearchQuery);
            return ReturnResponse(search);
        }

        public IActionResult ReturnResponse(object value)
        {
            return Ok(new { Response = value });
        }
    }
}
