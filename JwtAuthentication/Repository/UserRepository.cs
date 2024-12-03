using JwtAuthentication.Models;
using JwtAuthentication.Services;

namespace JwtAuthentication.Repository
{
    public class UserRepository : IUserService
    {
        private readonly List<User> _users = new()
    {
        new User { Id = 1, Username = "admin", Password = "1234", Role = "Admin" },
        new User { Id = 2, Username = "user", Password = "1234", Role = "User" }
    };

        public User Authenticate(string username, string password)
        {
            return _users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
