namespace Dji.Cloud.Domain.Mqtt.Handlers;

public class ServicesReplyHandler
{
//    @Autowired
//    private ObjectMapper mapper;

//    /**
//     * Handle the reply message from the pilot side to the on-demand video.
//     * @param message   reply message
//     * @throws IOException
//     */
//    @ServiceActivator(inputChannel = ChannelName.INBOUND_SERVICE_REPLY)
//    public void serviceReply(Message<?> message) throws IOException
//    {
//        byte[] payload = (byte[])message.getPayload();

//    CommonTopicReceiver receiver = mapper.readValue(payload, new TypeReference<CommonTopicReceiver>() { });
//        if (LogsFileMethodEnum.FILE_UPLOAD_LIST.getMethod().equals(receiver.getMethod())) {
//            LogsFileUploadList list = mapper.convertValue(receiver.getData(), new TypeReference<LogsFileUploadList>() { });
//    receiver.setData(list);
//        } else {
//            ServiceReply reply = mapper.convertValue(receiver.getData(), new TypeReference<ServiceReply>() { });
//receiver.setData(reply);
//        }
//        Chan < CommonTopicReceiver <?>> chan = Chan.getInstance();
//// Put the message to the chan object.
//chan.put(receiver);
//    }
}
