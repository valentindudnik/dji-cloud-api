using Dji.Cloud.Application.Abstracts.Configurations;
using Dji.Cloud.Application.Abstracts.Interfaces.Common;
using Dji.Cloud.Domain;
using Dji.Cloud.Domain.Manage;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Dji.Cloud.Application.Services.Common;

public class TokenService : ITokenService
{
    private const string apiParamName = "api_name";
    private const string idParamName = "id";
    private const string userNameParamName = "user_name";
    private const string userTypeParamName = "user_type";
    private const string workspaceIdParamName = "workspace_id";

    private readonly TokenConfiguration _tokenConfiguration;

    public TokenService(IOptions<TokenConfiguration> tokenConfigurationOptions)
    {
        _tokenConfiguration = tokenConfigurationOptions.Value;
    }
    
    public string GenerateToken(User user)
    {
        // generate token that is valid for 7 days
        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Issuer = _tokenConfiguration.Issuer,
            Subject = new ClaimsIdentity(new[] { new Claim(apiParamName, _tokenConfiguration.Subject!) }),
            Expires = DateTime.UtcNow.AddDays(7),
            Claims = new Dictionary<string, object> {
                { idParamName, user.UserId! },
                { userNameParamName, user.UserName! },
                { userTypeParamName, user.UserType },
                { workspaceIdParamName, user.WorkspaceId! }
            },
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenConfiguration.Secret!)), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    public TokenInfo GetTokenInfo(string token)
    {
        var jwtToken = GetToken(token);

        var result = new TokenInfo { 
            Id = jwtToken!.Claims.First(x => x.Type == idParamName).Value,
            UserName = jwtToken!.Claims.First(x => x.Type == userNameParamName).Value,
            UserType = jwtToken!.Claims.First(x => x.Type == userTypeParamName).Value,
            WorkspaceId = jwtToken!.Claims.First(x => x.Type == workspaceIdParamName).Value
        };

        return result;
    }

    public JwtSecurityToken? GetToken(string token)
    {
        if (token == null)
        {
            return null;
        }

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_tokenConfiguration.Secret!);
        try
        {
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);

            var jwtSecurityToken = (JwtSecurityToken)validatedToken;

            // return user id from JWT token if validation successful
            return jwtSecurityToken;
        }
        catch
        {
            // return null if validation fails
            return null;
        }
    }

    public string? ValidateToken(string token)
    {
        if (token == null)
        {
            return null;
        }

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_tokenConfiguration.Secret!);
        try
        {
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;
            var userId = jwtToken.Claims.First(x => x.Type == "id").Value;

            // return user id from JWT token if validation successful
            return userId;
        }
        catch
        {
            // return null if validation fails
            return null;
        }
    }
}
