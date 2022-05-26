using FlowerEShopAPI.BL.Services.ServiceInterfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace FlowerEShopAPI.BL.Middlewares
{

    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        public IConfiguration _configuration;

        public JwtMiddleware(RequestDelegate next, IConfiguration config)
        {
            _next = next;
            _configuration = config;
        }

        public async Task Invoke(HttpContext context, IUserService userService)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
            {
                await attachUserToContext(context, userService, token);
            }

            await _next(context);
        }

        private async Task attachUserToContext(HttpContext context, IUserService userService, string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    RequireExpirationTime = bool.Parse(_configuration["Jwt:RequireExpirationTime"]),
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = key,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = jwtToken.Claims.First(x => x.Type == "UserId").Value;

                // attach user to context on successful jwt validation
                context.Items["User"] = await userService.GetUserById(userId);
            }
            catch
            {
                // do nothing if jwt validation fails
                // user is not attached to context so request won't have access to secure routes
            }

        }
    }
}