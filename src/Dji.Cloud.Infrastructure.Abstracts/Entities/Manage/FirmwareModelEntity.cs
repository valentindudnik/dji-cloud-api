using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

public class FirmwareModelEntity : AuditableEntity
{
    public string? FirmwareId { get; set; }
    public string? DeviceName { get; set; }
}
