using Microsoft.AspNetCore.Identity;

namespace Proekt.Jwt
{
    public interface IJwtTokenService
    {
        Task<string> GenerateToken(IdentityUser<int> user);
    }
}
