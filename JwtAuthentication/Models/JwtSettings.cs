namespace JwtAuthentication.Models
{
    public class JwtSettings
    {
        public string JwtKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpiryInMinutes { get; set; } = 30;
    }
}