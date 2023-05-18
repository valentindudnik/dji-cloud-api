using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Wayline;

public class WaylineFileEntity : AuditableEntity
{
    public string? Name { get; set; }
    public string? WaylineId { get; set; }
    public string? DroneModelKey { get; set; }
    public string? PayloadModelKeys { get; set; }
    public string? Sign { get; set; }
    public string? WorkspaceId { get; set; }
    public bool Favorited { get; set; }
    public string? TemplateTypes { get; set; }
    public string? ObjectKey { get; set; }
    public string? UserName { get; set; }
}
