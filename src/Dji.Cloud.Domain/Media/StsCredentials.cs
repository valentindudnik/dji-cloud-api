namespace Dji.Cloud.Domain.Media;

public class StsCredentials
{
    public string? Bucket { get; set; }

    public Credentials? Credentials { get; set; }

    public string? Endpoint { get; set; }

    public string? ObjectKeyPrefix { get; set; }

    public string? Provider { get; set; }

    public string? Region { get; set; }
}
