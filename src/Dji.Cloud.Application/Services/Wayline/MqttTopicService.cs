using Dji.Cloud.Application.Abstracts.Interfaces.Wayline;

namespace Dji.Cloud.Application.Services.Wayline;

public class MqttTopicService : IMqttTopicService
{
    //@Resource
    //private MqttPahoMessageDrivenChannelAdapter adapter;

    //@Override
    //public void subscribe(String topic)
    //{
    //    log.debug("subscribe topic: {}", topic);
    //    adapter.addTopic(topic);
    //}

    //@Override
    //public void subscribe(String topic, int qos)
    //{
    //    log.debug("subscribe topic: {}", topic);
    //    adapter.addTopic(topic, qos);
    //}

    //@Override
    //public void unsubscribe(String topic)
    //{
    //    log.debug("unsubscribe topic: {}", topic);
    //    adapter.removeTopic(topic);
    //}

    //public String[] getSubscribedTopic()
    //{
    //    return adapter.getTopic();
    //}
    public Task SubscribeAsync()
    {
        throw new NotImplementedException();
    }
}
