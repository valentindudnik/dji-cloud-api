namespace Dji.Cloud.Application.Abstracts.Requests.Manage;

public class UserRequest
{
    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public string? WorkspaceName { get; set; }

    public string? UserType { get; set; }

    public string? MqttUserName { get; set; }

    public string? MqttPassword { get; set; }

    public DateTime CreateTime { get; set; }
}
