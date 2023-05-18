using Microsoft.AspNetCore.Http;

namespace Dji.Cloud.Infrastructure.Host.Extensions;

public static class HeaderExtensions
{
    private const string TokenHeaderName = "x-auth-token";

    public static string GetToken(this IHeaderDictionary headerDictionary)
    {
        var token = headerDictionary[TokenHeaderName];
        
        return token!;
    }
}
