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
    public class UsersController : ControllerBase, IUserController
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/Users/5
        [HttpGet]
        [TypeFilter(typeof(LogInterceptor))]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            var userContext = (User)HttpContext.Items["User"];
            var user = await _userService.GetUserById(userContext.Id.ToString());
            return ReturnResponse(user);
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [TypeFilter(typeof(LogInterceptor))]
        public async Task<IActionResult> Post([FromBody] UserCred userCred)
        {
            var createdUser = await _userService.CreateUser(userCred.Name, userCred.Email, userCred.Surname, userCred.Username, userCred.Password);
            return ReturnResponse(createdUser);
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [AuthorizeAttribute]
        [HttpPut("{id}")]
        [TypeFilter(typeof(LogInterceptor))]
        public async Task<IActionResult> Put([FromBody] UserCred userCred)
        {
            var user = (User)HttpContext.Items["User"];
            var updatedUser = await _userService.UpdateUser(user.Id.ToString(), userCred.Name, userCred.Email, userCred.Surname, userCred.Username, userCred.Password);
            return ReturnResponse(updatedUser);
        }

        public IActionResult ReturnResponse(object value)
        {
            return Ok(new { Response = value });
        }
    }
}
