namespace Dji.Cloud.Domain.Mqtt.Handlers;

public class RequestsRouter
{
//        @Autowired
//    private ObjectMapper mapper;

//        @Bean
//    public IntegrationFlow requestsMethodRouterFlow()
//        {
//            return IntegrationFlows
//                    .from(ChannelName.INBOUND_REQUESTS)
//                    .< byte[], CommonTopicReceiver > transform(payload-> {
//                try
//                {
//                    return mapper.readValue(payload, CommonTopicReceiver.class);
//                    } catch (IOException e) {
//                        e.printStackTrace();
//                    }
//return new CommonTopicReceiver();
//                })
//                .< CommonTopicReceiver, RequestsMethodEnum > route(
//                        receiver->RequestsMethodEnum.find(receiver.getMethod()),
//                                mapping->Arrays.stream(RequestsMethodEnum.values()).forEach(
//                                        methodEnum->mapping.channelMapping(methodEnum, methodEnum.getChannelName())))
//                .get();
//    }
}
