namespace Dji.Cloud.Domain.Mqtt.Handlers;

public class StateFirmwareVersionHandler
//extends AbstractStateTopicHandler
{
//    protected StateFirmwareVersionHandler(@Autowired @Qualifier("stateDefaultHandler") AbstractStateTopicHandler handler) {
//        super(handler);
//    }

//    @Override
//    public CommonTopicReceiver handleState(Map<String, Object> dataNode, CommonTopicReceiver stateReceiver, String sn) throws JsonProcessingException
//{
//        // Parse the firmware version of the device.
//        if (dataNode.containsKey(StateDataEnum.FIRMWARE_VERSION.getDesc())) {
//        FirmwareVersionReceiver firmware = mapper.convertValue(dataNode, FirmwareVersionReceiver.class);
//firmware.setSn(sn);
//firmware.setDomain(DeviceDomainEnum.SUB_DEVICE);
//stateReceiver.setData(firmware);
//return stateReceiver;
//        }

//        // Parse the firmware version of the payload.
//        List<String> payloads = PayloadModelEnum.getAllModel();
//long count = dataNode.keySet()
//        .stream()
//        .map(key-> {

//            int end = key.indexOf("-");
//return end == -1 ? key : key.substring(0, end);
//                })
//                .filter(payloads::contains)
//                .count();
//if (count > 0)
//{
//    FirmwareVersionReceiver firmware = FirmwareVersionReceiver.builder()
//            .firmwareVersion(((Map<String, String>)(dataNode.values().iterator().next()))
//                    .get(StateDataEnum.FIRMWARE_VERSION.getDesc()))
//            .sn(sn)
//            .domain(DeviceDomainEnum.PAYLOAD)
//            .build();
//    stateReceiver.setData(firmware);
//    return stateReceiver;
//}

//return handler.handleState(dataNode, stateReceiver, sn);
//    }
}
