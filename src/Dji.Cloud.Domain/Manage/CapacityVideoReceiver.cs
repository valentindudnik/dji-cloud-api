namespace Dji.Cloud.Domain.Manage;

public class CapacityVideoReceiver
{
    public string? VideoIndex { get; set; }

    public string? VideoType { get; set; }

    public IEnumerable<string>? SwitchableVideoTypes { get; set; }
}
