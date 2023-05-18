namespace Dji.Cloud.Domain.Manage;

public class CapacityVideo
{
    public string? Id { get; set; }

    public string? Index { get; set; }

    public string? Type { get; set; }

    public IEnumerable<string>? SwitchVideoTypes { get; set; }
}
