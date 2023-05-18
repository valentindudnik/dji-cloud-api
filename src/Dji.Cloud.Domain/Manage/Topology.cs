namespace Dji.Cloud.Domain.Manage;

public class Topology
{
    public IEnumerable<TopologyDevice>? Hosts { get; set; }

    public IEnumerable<TopologyDevice>? Parents { get; set; }
}
