using Dji.Cloud.Application.Abstracts.Interfaces.Websocket;
using Dji.Cloud.Domain.Websocket.Config;

namespace Dji.Cloud.Application.Services.Websocket;

public class WebSocketManageService : IWebSocketManageService
{
    //private static final ConcurrentHashMap<String, ConcurrentWebSocketSession> SESSIONS = new ConcurrentHashMap<>(16);

    //@Override
    //public void put(String key, ConcurrentWebSocketSession val)
    //{
    //    String[] name = key.split("/");
    //    if (name.length != 3)
    //    {
    //        log.debug("The key is out of format. [{workspaceId}/{userType}/{userId}]");
    //        return;
    //    }
    //    String sessionId = val.getId();
    //    String workspaceKey = RedisConst.WEBSOCKET_PREFIX + name[0];
    //    String userTypeKey = RedisConst.WEBSOCKET_PREFIX + UserTypeEnum.find(Integer.parseInt(name[1])).getDesc();
    //    RedisOpsUtils.hashSet(workspaceKey, sessionId, name[2]);
    //    RedisOpsUtils.hashSet(userTypeKey, sessionId, name[2]);
    //    SESSIONS.put(sessionId, val);
    //    RedisOpsUtils.expireKey(workspaceKey, RedisConst.WEBSOCKET_ALIVE_SECOND);
    //    RedisOpsUtils.expireKey(userTypeKey, RedisConst.WEBSOCKET_ALIVE_SECOND);
    //}

    //@Override
    //public void remove(String key, String sessionId)
    //{
    //    String[] name = key.split("/");
    //    if (name.length != 3)
    //    {
    //        log.debug("The key is out of format. [{workspaceId}/{userType}/{userId}]");
    //        return;
    //    }
    //    RedisOpsUtils.hashDel(RedisConst.WEBSOCKET_PREFIX + name[0], new String[] { sessionId });
    //    RedisOpsUtils.hashDel(RedisConst.WEBSOCKET_PREFIX + UserTypeEnum.find(Integer.parseInt(name[1])).getDesc(), new String[] { sessionId });
    //    SESSIONS.remove(sessionId);
    //}

    //@Override
    //public Collection<ConcurrentWebSocketSession> getValueWithWorkspace(String workspaceId)
    //{
    //    if (!StringUtils.hasText(workspaceId))
    //    {
    //        return Collections.emptySet();
    //    }
    //    String key = RedisConst.WEBSOCKET_PREFIX + workspaceId;

    //    return RedisOpsUtils.hashKeys(key)
    //            .stream()
    //            .map(SESSIONS::get)
    //            .filter(Objects::nonNull)
    //            .collect(Collectors.toSet());
    //}

    //@Override
    //public Collection<ConcurrentWebSocketSession> getValueWithWorkspaceAndUserType(String workspaceId, Integer userType)
    //{
    //    String key = RedisConst.WEBSOCKET_PREFIX + UserTypeEnum.find(userType).getDesc();
    //    return RedisOpsUtils.hashKeys(key)
    //            .stream()
    //            .map(SESSIONS::get)
    //            .filter(Objects::nonNull)
    //            .collect(Collectors.toSet());
    //}

    //@Override
    //public Long getConnectedCount()
    //{
    //    return SESSIONS.mappingCount();
    //}
    public WebSocketManageService()
    {
    }

    public Task<long> GetConnectedCountAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ConcurrentWebSocketSession>> GetValueWithWorkspaceAndUserTypeAsync(string workspaceId, int userType)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ConcurrentWebSocketSession>> GetValueWithWorkspaceAsync(string workspaceId)
    {
        throw new NotImplementedException();
    }

    public Task PutAsync(string key, ConcurrentWebSocketSession value)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(string key, string sessionId)
    {
        throw new NotImplementedException();
    }
}
