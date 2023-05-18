namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

public abstract class AuditableEntity : BaseEntity
{
    public long CreateTime { get; set; }

    public long? UpdateTime { get; set; }
}
