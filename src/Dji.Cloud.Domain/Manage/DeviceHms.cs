using Dji.Cloud.Domain.Common;

namespace Dji.Cloud.Domain.Manage;

public class DeviceHms : AuditableEntity
{
    public string? HmsId { get; set; }
    public string? Tid { get; set; }
    public string? Bid { get; set; }
    public string? SerialNumber { get; set; }
    public int Level { get; set; }
    public int Module { get; set; }
    public string? Key { get; set; }
    public string? MessageZh { get; set; }
    public string? MessageEn { get; set; }
}
