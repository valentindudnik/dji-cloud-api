using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

public class UserEntity : AuditableEntity
{
    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public int UserType { get; set; }

    public string? Password { get; set; }

    public string? WorkspaceId { get; set; }

    public string? MqttUserName { get; set; }

    public string? MqttPassword { get; set; }
}
