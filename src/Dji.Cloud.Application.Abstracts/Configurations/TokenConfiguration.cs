namespace Dji.Cloud.Application.Abstracts.Configurations;

public class TokenConfiguration
{
    public string? Issuer { get; set; }
    public string? Subject { get; set; }
    public string? Secret { get; set; }
    public long? Age { get; set; }
}
