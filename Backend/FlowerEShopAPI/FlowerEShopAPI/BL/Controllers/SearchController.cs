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
        private readonly ILogsService _logsService;
        public SearchController(ISearchService searchService, ILogsService logsService)
        {
            _searchService = searchService;
            _logsService = logsService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromBody] SearchBody body)
        {
            var user = (User)HttpContext.Items["User"];
            await _logsService.LogAction(user.UserName ?? "Guest", GetType().Name, "Get", "Searching for shops");
            var search = await _searchService.SearchShops(body.SearchQuery, body.PriceStart, body.PriceEnd, body.Status);
            await _logsService.LogAction(user.UserName ?? "Guest", GetType().Name, "Get", "Search completed");
            return ReturnResponse(search);
        }

        public IActionResult ReturnResponse(object value)
        {
            return Ok(new { Response = value });
        }
    }
}
