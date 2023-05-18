using Dji.Cloud.Domain.Websocket.Config;
using Dji.Cloud.Domain.Websocket.Models;
using System.Collections.ObjectModel;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Websocket;

public interface ISendMessageService
{
    /// <summary>
    /// Send a message to the specific connection.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="session">session</param>
    /// <param name="message">message</param>
    /// <returns></returns>
    Task SendMessageAsync<TEntity>(ConcurrentWebSocketSession session, CustomWebSocketMessage<TEntity> message) where TEntity : class;

    /// <summary>
    /// Send the same message to specific connection.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="sessions">sesssions</param>
    /// <param name="message">message</param>
    /// <returns></returns>
    Task SendBatchAsync<TEntity>(Collection<ConcurrentWebSocketSession> sessions, CustomWebSocketMessage<TEntity> message) where TEntity : class;
}
