using Dji.Cloud.Application.Abstracts.Requests.Common;
using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface IUserService
{
    /// <summary>
    /// Verify the username and password to log in.
    /// </summary>
    /// <param name="request">request</param>
    /// <returns></returns>
    Task<BaseResponse<User>> LoginAsync(UserLoginRequest request);

    /// <summary>
    /// Query user's details based on User Name.
    /// </summary>
    /// <param name="userName">user name</param>
    /// <param name="workspaceId">workspace id</param>
    /// <returns></returns>
    Task<BaseResponse<User>> GetUserByUserNameAsync(string userName, string workspaceId);

    /// <summary>
    /// Create a user object containing a new token.
    /// </summary>
    /// <param name="token">token</param>
    /// <returns>user</returns>
    Task<User> RefreshTokenAsync(string token);

    /// <summary>
    /// Query information about all users in a workspace.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="request">pagination request</param>
    /// <returns></returns>
    Task<PaginationResponse<UserInfo>> GetUsersByWorkspaceIdAsync(string workspaceId, PaginationRequest request);

    /// <summary>
    /// Update user
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="userId">user id</param>
    /// <param name="request">user</param>
    /// <returns>status</returns>
    Task<bool> UpdateUserAsync(string workspaceId, string userId, UserRequest request);
}
