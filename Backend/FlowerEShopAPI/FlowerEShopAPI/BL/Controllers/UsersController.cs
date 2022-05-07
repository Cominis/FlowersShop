using FlowerEShopAPI.BL.Attributes;
using FlowerEShopAPI.BL.Controllers.Interfaces;
using FlowerEShopAPI.DAL.Entities;
using FlowerEShopAPI.Services.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using static FlowerEShopAPI.BL.Models.Body;

namespace FlowerEShopAPI.BL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase, IUserController
    {
        private readonly IUserService _userService;
        private readonly ILogsService _logsService;
        public UsersController(IUserService userService, ILogsService logsService)
        {
            _userService = userService;
            _logsService = logsService;
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var user = await _userService.GetUserById(id);
            await _logsService.LogAction(user.UserName, GetType().Name, "Get", "User with id: " + id + "found");
            return ReturnResponse(user);
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserCred userCred)
        {
            var createdUser = await _userService.CreateUser(userCred.Name, userCred.Email, userCred.Surname, userCred.Username, userCred.Password);
            await _logsService.LogAction(createdUser.UserName, GetType().Name, "Post", "User with id: " + createdUser.Id + "created");
            return ReturnResponse(createdUser);
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [AuthorizeAttribute]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] UserCred userCred)
        {
            var user = (User)HttpContext.Items["User"];
            var updatedUser = await _userService.UpdateUser(user.Id.ToString(), userCred.Name, userCred.Email, userCred.Surname, userCred.Username, userCred.Password);
            await _logsService.LogAction(updatedUser.UserName, GetType().Name, "Update", "User with id: " + updatedUser.Id + "updated");
            return ReturnResponse(updatedUser);
        }

        public IActionResult ReturnResponse(object value)
        {
            return Ok(new { Response = value });
        }
    }
}
