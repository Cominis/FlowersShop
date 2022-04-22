using FlowerEShopAPI.BL.Controllers.Interfaces;
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

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var user = await _userService.GetUserById(id);
            return ReturnResponse(user);
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserCred userCred)
        {
            var createdUser = await _userService.CreateUser(userCred.Name, userCred.Email, userCred.Surname, userCred.Username, userCred.Password);

            return ReturnResponse(createdUser);
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] UserCred userCred)
        {
            var updatedUser = await _userService.UpdateUser(id, userCred.Name, userCred.Email, userCred.Surname, userCred.Username, userCred.Password);

            return ReturnResponse(updatedUser);
        }

        public IActionResult ReturnResponse(object value) => Ok(new { Response = value });
    }
}
