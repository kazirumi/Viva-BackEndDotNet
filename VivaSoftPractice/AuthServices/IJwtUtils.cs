using VivaSoftPractice.Model;

namespace VivaSoftPractice.AuthServices
{
    public interface IJwtUtils
    {
        string GenerateJwtToken(User user);
        public string? ValidateJwtToken(string token);
    }
}