using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthentication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        [HttpGet("admin-data")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAdminData()
        {
            return Ok("این داده‌ها فقط برای ادمین است.");
        }

        [HttpGet("user-data")]
        [Authorize(Roles = "User")]
        public IActionResult GetUserData()
        {
            return Ok("این داده‌ها فقط برای کاربران معمولی است.");
        }
    }
}