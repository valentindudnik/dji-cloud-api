namespace Dji.Cloud.Domain.Mqtt.Handlers;

public class EventsRouter
{
    //@Autowired
    //private ObjectMapper mapper;

    //@Bean
    //public IntegrationFlow eventsMethodRouterFlow()
    //{
    //    return IntegrationFlows
    //            .from(ChannelName.INBOUND_EVENTS)
    //            .< byte[], CommonTopicReceiver > transform(payload-> {
    //        try
    //        {
    //            return mapper.readValue(payload, CommonTopicReceiver.class);
    //                } catch (IOException e) {
    //                    e.printStackTrace();
    //                }
    //                return new CommonTopicReceiver();
    //            })
    //            .< CommonTopicReceiver, EventsMethodEnum > route(
    //                    receiver->EventsMethodEnum.find(receiver.getMethod()),
    //                    mapping->Arrays.stream(EventsMethodEnum.values()).forEach(
    //                            methodEnum->mapping.channelMapping(methodEnum, methodEnum.getChannelName())))
    //            .get();
    //}
}
