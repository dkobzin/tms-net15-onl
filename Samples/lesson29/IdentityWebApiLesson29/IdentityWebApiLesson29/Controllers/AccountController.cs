using IdentityWebApiLesson29.Data;
using IdentityWebApiLesson29.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IdentityModel.Tokens.Jwt;

namespace IdentityWebApiLesson29.Controllers
{
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly JwtHandler jwtHandler;

        public AccountController(UserManager<IdentityUser> userManager, JwtHandler jwtHandler)
        {
            this.userManager = userManager;
            this.jwtHandler = jwtHandler;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(ApiLoginRequest loginRequest)
        {
            var user = await userManager.FindByNameAsync(loginRequest.Email);
            if (user == null
                || !await userManager.CheckPasswordAsync(user, loginRequest.Password))
                return Unauthorized(new ApiLoginResult()
                {
                    Success = false,
                    Message = "Invalid Email or Password."
                });
            var secToken = await jwtHandler.GetTokenAsync(user);
            var jwt = new JwtSecurityTokenHandler().WriteToken(secToken);
            return Ok(new ApiLoginResult()
            {
                Success = true,
                Message = "Login successful",
                Token = jwt
            });
        }
    }
}
