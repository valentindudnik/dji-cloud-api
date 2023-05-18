namespace Dji.Cloud.Application.Abstracts.Requests.Manage;

public class UserLoginRequest
{
    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int Flag { get; set; }
}
