using JwtAuthentication.Models;
using JwtAuthentication.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace JwtAuthentication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
        [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly JwtSettings _jwtSettings;
        private readonly IUserService _userService;
        private readonly IAuthService _authService;

        public AuthController(IOptions<JwtSettings> jwtSettings, IUserService userService, IAuthService authService)
        {
            _jwtSettings = jwtSettings.Value;
            _userService = userService;
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // بررسی اطلاعات کاربر
            var user = _userService.Authenticate(request.Username, request.Password);
            if (user == null) return Unauthorized("نام کاربری یا رمز عبور اشتباه است.");

            // تولید توکن
            var token = _authService.GenerateJwtToken(user, _jwtSettings);
            return Ok(new { Token = token });
        }
    }
}
