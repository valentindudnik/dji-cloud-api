using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

public class DeviceHmsEntity : AuditableEntity
{
    public string? HmsId { get; set; }
    public string? Tid { get; set; }
    public string? Bid { get; set; }
    public string? SerialNumber { get; set; }
    public int Level { get; set; }
    public int Module { get; set; }
    public string? HmsKey { get; set; }
    public string? MessageZh { get; set; }
    public string? MessageEn { get; set; }
}
