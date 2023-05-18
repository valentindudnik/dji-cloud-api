using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

public class DeviceFirmwareEntity : AuditableEntity
{
    public string? FirmwareId { get; set; }
    public string? FileName { get; set; }
    public string? FirmwareVersion { get; set; }
    public string? ObjectKey { get; set; }
    public long FileSize { get; set; }
    public string? FileMd5 { get; set; }
    [NotMapped]
    public string? DeviceName { get; set; }
    public string? ReleaseNote { get; set; }
    public long ReleaseDate { get; set; }
    public bool Status { get; set; }
    public string? WorkspaceId { get; set; }
    public string? UserName { get; set; }
}
