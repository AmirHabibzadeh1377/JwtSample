using JwtAuthentication.Models;

namespace JwtAuthentication.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
    }
}