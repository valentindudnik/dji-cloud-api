using Dji.Cloud.Domain.Manage;
using Dji.Cloud.Domain.Mqtt.Models;
using Dji.Cloud.Domain.Websocket.Config;
using Dji.Cloud.Domain.Websocket.Models;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface ITSAService
{
    /// <summary>
    /// Real-time push telemetry data.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="osdData">osd data</param>
    /// <param name="serialNumber">serial number</param>
    /// <returns></returns>
    Task PushTelemetryDataAsync(string workspaceId, object osdData, string serialNumber);

    /// <summary>
    /// Handle device's osd data.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="receiver">receiver</param>
    /// <param name="device">device</param>
    /// <param name="webSessions">web sessions</param>
    /// <param name="wsMessage">ws message</param>
    /// <returns></returns>
    Task HandleOSDAsync<TEntity>(CommonTopicReceiver<TEntity> receiver, Device device,
                                 IEnumerable<ConcurrentWebSocketSession> webSessions, CustomWebSocketMessage<Telemetry<TEntity>> wsMessage) where TEntity : class;
}
