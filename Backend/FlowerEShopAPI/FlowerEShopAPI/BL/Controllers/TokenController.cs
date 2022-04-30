using FlowerEShopAPI.BL.Services.ServiceInterfaces;
using FlowerEShopAPI.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static FlowerEShopAPI.BL.Models.Body;

namespace FlowerEShopAPI.BL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        private readonly IUserService _userService;

        public TokenController(IConfiguration config, IUserService userService)
        {
            _configuration = config;
            _userService = userService;
        }

        [HttpPost]
        [TypeFilter(typeof(LogInterceptor))]
        public async Task<IActionResult> login(UserLogin _userData)
        {
            if (_userData != null && _userData.Email != null && _userData.Password != null)
            {
                var user = await GetUser(_userData.Email);

                if (user != null && BCrypt.Net.BCrypt.Verify(_userData.Password, user.Password))
                {
                    //create claims details based on the user information
                    var claims = new[] {
                        new Claim("UserId", user.Id.ToString()),
                        new Claim("Email", user.Email),
                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddMinutes(10),
                        signingCredentials: signIn);

                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    throw new ArgumentException("Wrong email or passwrod");
                }
            }
            else
            {
                return BadRequest();
            }
        }

        private async Task<User?> GetUser(string email)
        {
            return await _userService.GetUserByEmail(email);
        }
    }
}