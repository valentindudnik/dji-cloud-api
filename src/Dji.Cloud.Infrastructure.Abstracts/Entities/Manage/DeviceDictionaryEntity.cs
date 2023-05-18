using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

public class DeviceDictionaryEntity : BaseEntity
{
    public int Domain { get; set; }
    public int DeviceType { get; set; }
    public int SubType { get; set; }
    public string? DeviceName { get; set; }
    public string? DeviceDesc { get; set; }
}
