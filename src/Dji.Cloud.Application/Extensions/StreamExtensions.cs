using System.Security.Cryptography;
using System.Text;

namespace Dji.Cloud.Application.Extensions;

public static class StreamExtensions
{
    /// <summary>
    /// A Stream extension method that converts the @this to a md 5 hash.
    /// </summary>
    /// <param name="stream">The @this to act on.</param>
    /// <returns>@this as a string.</returns>
    public static string ToMD5Hash(this Stream stream)
    {
        using var md5 = MD5.Create();
        byte[] hashBytes = md5.ComputeHash(stream);
        var stringBuilder = new StringBuilder();
        foreach (byte bytes in hashBytes)
        {
            stringBuilder.Append(bytes.ToString("X2"));
        }

        return stringBuilder.ToString();
    }
}
