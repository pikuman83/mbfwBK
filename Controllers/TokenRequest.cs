using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using mbfwAPI.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;

namespace mbfwAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenRequest : ControllerBase
    {
        private readonly Mbfwcontext _userManager;
        //private UserManager<Login> _userManager;
        private readonly ApplicationSettings _appSettings;

        public TokenRequest(Mbfwcontext userManager, IOptions<ApplicationSettings> appSettings)
        {
            _userManager = userManager;
            _appSettings = appSettings.Value;
        }
        
        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        //POST : /api/TokenRequest/Login

        public async Task<IActionResult> Login(Login users)
        {
            var user = _userManager.Logins.Where(u => u.Usernm == users.Usernm && u.Passwrd == users.Passwrd).FirstOrDefault();
            if (user != null)
            {

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserID", user.Usernm)
                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                return Ok(new { token });
            }
            else
                return BadRequest(new { message = "Username or password is incorrect." });
        }
    }
}
// Do not see where the data is being posted, if doesn't work, change it to simple post method.
//[HttpPost]
//[Route("Register")]
////POST : /api/ApplicationUser/Register
//public async Task<Object> PostApplicationUser(Login user)
//{
//    var applicationUser = new Login()
//    {
//        Usernm = user.Usernm,
//        Type = user.Type,
//    };

//    try
//    {
//        var result = await _userManager.CreateAsync(applicationUser, user.Passwrd);
//        return Ok(result);
//    }
//    catch (Exception)
//    {

//        throw;
//    }
//}
