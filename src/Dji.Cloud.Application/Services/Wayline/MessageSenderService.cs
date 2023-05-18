using Dji.Cloud.Application.Abstracts.Interfaces.Wayline;
using Dji.Cloud.Domain.Mqtt.Models;

namespace Dji.Cloud.Application.Services.Wayline;

public class MessageSenderService<TEntity> : IMessageSenderService<TEntity> where TEntity : class, new()
{
    //    @Autowired
    //    private IMqttMessageGateway messageGateway;

    //    @Autowired
    //    private ObjectMapper mapper;

    //    public void publish(String topic, CommonTopicResponse response)
    //    {
    //        try
    //        {
    //            log.info("send topic: {}, payload: {}", topic, response.toString());
    //            messageGateway.publish(topic, mapper.writeValueAsBytes(response));
    //        }
    //        catch (JsonProcessingException e)
    //        {
    //            log.info("Failed to publish the message. {}", response.toString());
    //            e.printStackTrace();
    //        }
    //    }

    //    public void publish(String topic, int qos, CommonTopicResponse response)
    //    {
    //        try
    //        {
    //            messageGateway.publish(topic, mapper.writeValueAsBytes(response), qos);
    //        }
    //        catch (JsonProcessingException e)
    //        {
    //            log.info("Failed to publish the message. {}", response.toString());
    //            e.printStackTrace();
    //        }
    //    }

    //    public ServiceReply publishWithReply(String topic, CommonTopicResponse response)
    //    {
    //        return this.publishWithReply(ServiceReply.class, topic, response, 2);
    //    }

    //public <T> T publishWithReply(Class<T> clazz, String topic, CommonTopicResponse response, int retryTime)
    //{
    //    log.info("send topic: {}, payload: {}", topic, response.toString());
    //    AtomicInteger time = new AtomicInteger(0);
    //    // Retry three times
    //    while (time.getAndIncrement() <= retryTime)
    //    {
    //        this.publish(topic, response);

    //        Chan<CommonTopicReceiver<T>> chan = Chan.getInstance();
    //        // If the message is not received in 0.5 seconds then resend it again.
    //        CommonTopicReceiver<T> receiver = chan.get(response.getTid());
    //        if (receiver == null)
    //        {
    //            continue;
    //        }
    //        // Need to match tid and bid.
    //        if (receiver.getTid().equals(response.getTid()) &&
    //                receiver.getBid().equals(response.getBid()))
    //        {
    //            return receiver.getData();
    //        }
    //    }
    //    throw new RuntimeException("No message reply received.");
    //}
    public Task PublishAsync(string topic, CommonTopicResponse<TEntity> response)
    {
        throw new NotImplementedException();
    }

    public Task PublishAsync(string topic, int qos, CommonTopicResponse<TEntity> response)
    {
        throw new NotImplementedException();
    }

    public Task<ServiceReply<TEntity>> PublishWithReplyAsync(string topic, CommonTopicResponse<TEntity> response)
    {
        throw new NotImplementedException();
    }
}
