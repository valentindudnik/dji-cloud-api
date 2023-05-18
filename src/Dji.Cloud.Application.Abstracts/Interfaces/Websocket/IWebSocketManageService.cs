using Dji.Cloud.Domain.Websocket.Config;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Websocket;

public interface IWebSocketManageService
{
    Task PutAsync(string key, ConcurrentWebSocketSession value);

    Task RemoveAsync(string key, string sessionId);

    Task<IEnumerable<ConcurrentWebSocketSession>> GetValueWithWorkspaceAsync(string workspaceId);

    Task<IEnumerable<ConcurrentWebSocketSession>> GetValueWithWorkspaceAndUserTypeAsync(string workspaceId, int userType);

    Task<long> GetConnectedCountAsync();
}
