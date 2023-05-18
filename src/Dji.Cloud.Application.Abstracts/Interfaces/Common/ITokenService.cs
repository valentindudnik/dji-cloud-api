using Dji.Cloud.Domain;
using Dji.Cloud.Domain.Manage;
using System.IdentityModel.Tokens.Jwt;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Common;

public interface ITokenService
{
    string GenerateToken(User user);

    string? ValidateToken(string token);

    JwtSecurityToken? GetToken(string token);

    TokenInfo GetTokenInfo(string token);
}
