using SignupLoginValidation.Models.DTO;
using System.Security.Claims;

namespace SignupLoginValidation.Repositories.Interfaces
{
    public interface ITokenService
    {
        TokenResponse GetToken(IEnumerable<Claim> claim);
        string GetRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
