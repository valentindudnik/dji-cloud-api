namespace Dji.Cloud.Domain.Mqtt.Handlers;

public class StateRouter
{
//    @Resource(name = "stateDeviceBasicHandler")
//    private AbstractStateTopicHandler handler;

//    @Autowired
//    private ObjectMapper mapper;

//    /**
//     * Handles the routing of state topic messages. Depending on the data, it is assigned to different channels for handling.
//     * @param message
//     * @return
//     * @throws IOException
//     */
//    @ServiceActivator(inputChannel = ChannelName.INBOUND_STATE, outputChannel = ChannelName.INBOUND_STATE_SPLITTER)
//    public CommonTopicReceiver<?> resolveStateData(Message<?> message) throws IOException
//    {
//        byte[] payload = (byte[])message.getPayload();
//    String topic = message.getHeaders().get(MqttHeaders.RECEIVED_TOPIC).toString();

//    CommonTopicReceiver stateReceiver = mapper.readValue(payload, CommonTopicReceiver.class);
//        // Get the sn of the topic source.
//        String from = topic.substring((THING_MODEL_PRE + PRODUCT).length(),
//                topic.indexOf(STATE_SUF));

//        try {
//            Map<String, Object> data = (Map<String, Object>)(stateReceiver.getData());

//            return handler.handleState(data, stateReceiver, from);

//        } catch (UnrecognizedPropertyException e) {
//            log.info("The {} data is not processed.", e.getPropertyName());
//        }
//        return stateReceiver;
//    }

//    /**
//     * Split the state message data to different channels for handling according to their different types.
//     * @param receiver state message
//     * @return
//     */
//    @Splitter(inputChannel = ChannelName.INBOUND_STATE_SPLITTER, outputChannel = ChannelName.INBOUND_STATE_ROUTER)
//    public Collection<Object> splitState(CommonTopicReceiver receiver)
//{
//    ArrayList<Object> type = new ArrayList<>();
//    type.add(receiver.getData());
//    return type;
//}

//@Bean
//    @Router(inputChannel = ChannelName.INBOUND_STATE_ROUTER)
//    public MessageRouter resolveStateRouter()
//{
//    PayloadTypeRouter router = new PayloadTypeRouter();
//    // Channel mapping for basic data.
//    router.setChannelMapping(DeviceBasicReceiver.class.getName(),
//                ChannelName.INBOUND_STATE_BASIC);
//// Channel mapping for live streaming capabilities.
//router.setChannelMapping(LiveCapacityReceiver.class.getName(),
//                ChannelName.INBOUND_STATE_CAPACITY);
//router.setChannelMapping(FirmwareVersionReceiver.class.getName(),
//                ChannelName.INBOUND_STATE_FIRMWARE_VERSION);
//router.setChannelMapping(Map.class.getName(),
//                ChannelName.DEFAULT);
//return router;
//    }
}
