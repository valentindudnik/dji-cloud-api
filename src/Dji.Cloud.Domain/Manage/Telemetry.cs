namespace Dji.Cloud.Domain.Manage;

public class Telemetry<TEntity> where TEntity : class
{
    public TEntity? Host { get; set; }

    public string? SerialNumber { get; set; }
}
