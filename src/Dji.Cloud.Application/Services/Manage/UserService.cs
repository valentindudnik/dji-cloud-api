using AutoMapper;
using Dji.Cloud.Application.Abstracts.Interfaces.Common;
using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Abstracts.Requests.Common;
using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Manage;
using Dji.Cloud.Domain.Mqtt.Config;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Dji.Cloud.Infrastructure.Abstracts.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net;

namespace Dji.Cloud.Application.Services.Manage;

public class UserService : IUserService
{
    private readonly MqttConfiguration _mqttConfiguration;

    private readonly ITokenService _tokenService;
    private readonly IWorkspaceService _workspaceService;
    private readonly IGenericRepository<UserEntity> _userRepository;

    private readonly IMapper _mapper;
    private readonly ILogger<UserService> _logger;

    public UserService(IOptions<MqttConfiguration> mqttConfigurationOptions,
                       ITokenService tokenService,
                       IWorkspaceService workspaceService,
                       IGenericRepository<UserEntity> userRepository, 
                       IMapper mapper,
                       ILogger<UserService> logger)
    {
        _mqttConfiguration = mqttConfigurationOptions.Value;

        _tokenService = tokenService;
        _workspaceService = workspaceService;
        _userRepository = userRepository;
        
        _mapper = mapper;
        _logger = logger;
    }

    /// <summary>
    /// Get user by User Name
    /// </summary>
    /// <param name="userName"></param>
    /// <param name="workspaceId"></param>
    /// <returns></returns>
    public async Task<BaseResponse<User>> GetUserByUserNameAsync(string userName, string workspaceId)
    {
        _logger.LogInformation($"{nameof(GetUserByUserNameAsync)} was called with User Name: {userName} and Workspace Id: {workspaceId}.");
        
        BaseResponse<User>? response;

        var userEntity = await GetUserAsync(userName);
        if (userEntity == null)
        {
            const string message = "Invalid User Name";
            _logger.LogError(message);

            response = BaseResponse<User>.Error((int)HttpStatusCode.Unauthorized, message);
        }
        else
        {
            // Convert database entity objects into user data transfer object.
            var user = _mapper.Map<User>(userEntity);
            
            // TODO: need to recheck initial logic
            user.WorkspaceId = workspaceId;
            user.MqttAddr = _mqttConfiguration.MqttAddress;

            _logger.LogInformation($"{nameof(GetUserByUserNameAsync)} was called with with User Name: {user.UserName} was getting successfully.");

            response = BaseResponse<User>.Success(user);
        }

        return response; 
    }

    /// <summary>
    /// Get users by workspace id
    /// </summary>
    /// <param name="page"></param>
    /// <param name="pageSize"></param>
    /// <param name="workspaceId"></param>
    /// <returns></returns>
    public async Task<PaginationResponse<UserInfo>> GetUsersByWorkspaceIdAsync(string workspaceId, PaginationRequest request)
    {
        _logger.LogInformation($"{nameof(GetUsersByWorkspaceIdAsync)} was called with Workspace Id: {workspaceId}.");

        var userEntities = await _userRepository.FindAsync(entity => entity.WorkspaceId == workspaceId, request.Page, request.PageSize);

        var total = await _userRepository.GetCountAsync();

        var users = _mapper.Map<IEnumerable<UserInfo>>(userEntities);

        var response = new PaginationResponse<UserInfo> {
            List = users,
            Pagination = new Pagination { Page = request.Page, PageSize = request.PageSize, Total = total }
        };

        _logger.LogInformation($"{nameof(GetUsersByWorkspaceIdAsync)} was getting users with Workspace Id: {workspaceId}.");

        return response;
    }

    /// <summary>
    /// Query a user by User Name.
    /// </summary>
    /// <param name="userName"></param>
    /// <returns></returns>
    private async Task<UserEntity> GetUserAsync(string userName)
    {
        _logger.LogInformation($"{nameof(GetUserAsync)} was called with User Name: {userName}.");

        var userEntity = await _userRepository.FirstOrDefaultAsync(x => x.UserName == userName);

        _logger.LogInformation($"{nameof(GetUserAsync)} was getting user with User Name: {userName}.");

        return userEntity!;
    }

    /// <summary>
    /// Login user
    /// </summary>
    /// <param name="request">user login request</param>
    /// <returns>user</returns>
    public async Task<BaseResponse<User>> LoginAsync(UserLoginRequest request)
    {
        _logger.LogInformation($"{nameof(LoginAsync)} was called with User Name: {request.UserName}.");

        // Check user
        BaseResponse<User> response;

        var userEntity = await GetUserAsync(request.UserName!);
        if (userEntity == null)
        {
            const string message = "Invalid User Name";

            _logger.LogError(message);
            response = BaseResponse<User>.Error((int)HttpStatusCode.Unauthorized, message);
        }
        else if (request.Flag != userEntity?.UserType)
        {
            const string message = "The account type does not match.";

            _logger.LogError(message);
            response = BaseResponse<User>.Error((int)HttpStatusCode.Unauthorized, message);
        }
        else if (request.Password != userEntity?.Password)
        {
            const string message = "Invalid Password.";

            _logger.LogError(message);
            response = BaseResponse<User>.Error((int)HttpStatusCode.Unauthorized, message);
        }
        else
        {
            var workspace = await _workspaceService.GetWorkspaceByWorkspaceIdAsync(userEntity?.WorkspaceId!);
            if (workspace == null)
            {
                const string message = "Invalid workspace id.";

                _logger.LogError(message);
                response = BaseResponse<User>.Error((int)HttpStatusCode.Unauthorized, message);
            }
            else
            {
                var user = _mapper.Map<User>(userEntity);
                var accessToken = _tokenService.GenerateToken(user);
                
                user.AccessToken = accessToken;
                user.WorkspaceId = workspace?.WorkspaceId;
                user.MqttAddr = _mqttConfiguration.MqttAddress;

                response = BaseResponse<User>.Success(user);
            }
        }

        _logger.LogInformation($"{nameof(LoginAsync)} was getting user successfully with User Name: {request.UserName}.");

        return response;
    }

    /// <summary>
    /// Refresh token
    /// </summary>
    /// <param name="token"></param>
    /// <returns></returns>
    public async Task<User> RefreshTokenAsync(string token)
    {
        _logger.LogInformation($"{RefreshTokenAsync} was called with token: {token}.");

        var userId = _tokenService.ValidateToken(token);

        var userEntity = await _userRepository.FirstOrDefaultAsync(x => x.UserId == userId);

        var user = _mapper.Map<User>(userEntity);

        var accessToken = _tokenService.GenerateToken(user);
        
        user.AccessToken = accessToken;

        _logger.LogInformation($"{RefreshTokenAsync} was refreshed successfully with token: {token}.");

        return user;
    }

    /// <summary>
    /// Update user
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="userId">user id</param>
    /// <param name="request">user request</param>
    /// <returns></returns>
    public async Task<bool> UpdateUserAsync(string workspaceId, string userId, UserRequest request)
    {
        _logger.LogInformation($"{UpdateUserAsync} was called with Workspace Id: {workspaceId} and User Id: {userId}.");

        var result = true;

        var userEntity = await _userRepository.FirstOrDefaultAsync(x => x.UserId == userId && x.WorkspaceId == workspaceId);
        if (userEntity == null)
        {
            result = false;

            return result;
        }

        userEntity.UserId = userId;
        userEntity.UserName = request.UserName;
        
        // TODO: need to re-check user type
        //userEntity.UserType = userRequest.UserType;
        
        userEntity.MqttUserName = request.MqttUserName;
        userEntity.MqttPassword = request.MqttPassword;
        userEntity.UpdateTime = DateTime.UtcNow.Millisecond;

        await _userRepository.UpdateAsync(userEntity);

        _logger.LogInformation($"{UpdateUserAsync} was updated successfully with Workspace Id: {workspaceId} and User Id: {userId}.");

        return result;
    }
}
