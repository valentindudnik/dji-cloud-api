using Dji.Cloud.Domain.Mqtt.Models;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Wayline;

public interface IMessageSenderService<TEntity> where TEntity : class, new()
{
    /// <summary>
    /// Publish a message to a specific topic.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="topic">topic</param>
    /// <param name="response">response</param>
    /// <returns></returns>
    Task PublishAsync(string topic, CommonTopicResponse<TEntity> response);

    /// <summary>
    /// Use a specific qos to push messages to a specific topic.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="topic">topic</param>
    /// <param name="qos">qos</param>
    /// <param name="response">response</param>
    /// <returns></returns>
    Task PublishAsync(string topic, int qos, CommonTopicResponse<TEntity> response);

    /// <summary>
    /// Send live streaming start message and receive a response at the same time.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="topic">topic</param>
    /// <param name="response">notification of whether the start is successful.</param>
    /// <returns></returns>
    Task<ServiceReply<TEntity>> PublishWithReplyAsync(string topic, CommonTopicResponse<TEntity> response);
}
