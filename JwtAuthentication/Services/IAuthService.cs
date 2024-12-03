using JwtAuthentication.Models;

namespace JwtAuthentication.Services
{
    public interface IAuthService
    {
        string GenerateJwtToken(User user, JwtSettings settings);
    }
}