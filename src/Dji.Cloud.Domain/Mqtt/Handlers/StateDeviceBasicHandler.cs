namespace Dji.Cloud.Domain.Mqtt.Handlers;

public class StateDeviceBasicHandler
    //extends AbstractStateTopicHandler
{

//    public StateDeviceBasicHandler(@Autowired @Qualifier("stateLiveCapacityHandler") AbstractStateTopicHandler handler) {
//        super(handler);
//    }

//    @Override
//    public CommonTopicReceiver handleState(Map<String, Object> dataNode, CommonTopicReceiver stateReceiver, String sn) throws JsonProcessingException
//{
//        // handle device basic data
//        if (dataNode.containsKey(StateDataEnum.PAYLOADS.getDesc())) {
//        DeviceBasicReceiver data = mapper.convertValue(stateReceiver.getData(), DeviceBasicReceiver.class);
//data.setDeviceSn(sn);
//data.getPayloads().forEach(payload->payload.setDeviceSn(sn));

//stateReceiver.setData(data);
//return stateReceiver;
//        }
//        return handler.handleState(dataNode, stateReceiver, sn);
//    }
//}
}
