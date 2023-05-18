namespace Dji.Cloud.Domain.Mqtt.Handlers;

public class InboundMessageRouter
{
    //extends AbstractMessageRouter {

    /**
     * All mqtt broker messages will arrive here before distributing them to different channels.
     * @param message message from mqtt broker
     * @return channel
     */
//    @Override
//    @Router(inputChannel = ChannelName.INBOUND)
//    protected Collection<MessageChannel> determineTargetChannels(Message<?> message)
//{
//    MessageHeaders headers = message.getHeaders();
//    String topic = headers.get(MqttHeaders.RECEIVED_TOPIC).toString();
//    byte[] payload = (byte[])message.getPayload();

//    log.debug("received topic :{} \t payload :{}", topic, new String(payload));

//    DeviceTopicEnum topicEnum = DeviceTopicEnum.find(topic);
//    MessageChannel bean = (MessageChannel)SpringBeanUtils.getBean(topicEnum.getBeanName());

//    return Collections.singleton(bean);
//}
}
