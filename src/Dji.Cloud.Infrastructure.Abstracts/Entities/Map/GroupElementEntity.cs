using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Map;

public class GroupElementEntity : AuditableEntity
{
    public string? GroupId { get; set; }
    public string? ElementId { get; set; }
    public string? ElementName { get; set; }
    public int Display { get; set; }
    public int ElementType { get; set; }
    public string? UserName { get; set; }
    public string? Color { get; set; }
    public bool ClampToGround { get; set; }
}
