using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Services.Websocket;
using System.Collections.ObjectModel;

namespace Dji.Cloud.Application.Services.Manage;

public class DeviceOSDService
{
//    protected DeviceOSDServiceImpl(@Autowired @Qualifier("dockOSDServiceImpl") AbstractTSAService tsaService) {
//        super(tsaService);
//}

//@Override
//    public void pushTelemetryData(Collection<ConcurrentWebSocketSession> sessions,
//                                  CustomWebSocketMessage<TelemetryDTO> message, Object osdData)
//{
//    if (osdData instanceof OsdSubDeviceReceiver) {
//        OsdSubDeviceReceiver data = (OsdSubDeviceReceiver)osdData;
//        TelemetryDTO telemetry = message.getData();
//        telemetry.setHost(TelemetryDeviceDTO.builder()
//                .latitude(data.getLatitude())
//                .longitude(data.getLongitude())
//                .altitude(data.getElevation())
//                .attitudeHead(data.getAttitudeHead())
//                .elevation(data.getElevation())
//                .horizontalSpeed(data.getHorizontalSpeed())
//                .verticalSpeed(data.getVerticalSpeed())
//                .build());

//        this.sendMessageService.sendBatch(sessions, message);
//    }
//}
//@Override
//    public void handleOSD(CommonTopicReceiver receiver, DeviceDTO device,
//                          Collection<ConcurrentWebSocketSession> webSessions,
//                          CustomWebSocketMessage<TelemetryDTO> wsMessage)
//{
//    if (DeviceDomainEnum.SUB_DEVICE.getVal() == device.getDomain())
//    {
//        wsMessage.setBizCode(BizCodeEnum.DEVICE_OSD.getCode());

//        OsdSubDeviceReceiver data = mapper.convertValue(receiver.getData(), OsdSubDeviceReceiver.class);
//            List<DevicePayloadDTO> payloadsList = device.getPayloadsList();
//            try {
//                Map<String, Object> receiverData = (Map<String, Object>)receiver.getData();
//data.setPayloads(payloadsList.stream()
//                        .map(payload -> mapper.convertValue(
//                                receiverData.getOrDefault(payload.getPayloadName(), Map.of()),
//                                OsdPayloadReceiver.class))
//                        .collect(Collectors.toList()));

//            } catch (NullPointerException e) {
//    log.warn("Please remount the payload, or restart the drone. Otherwise the data of the payload will not be received.");
//}

//RedisOpsUtils.setWithExpire(RedisConst.OSD_PREFIX + device.getDeviceSn(), data, RedisConst.DEVICE_ALIVE_SECOND);
//wsMessage.getData().setHost(data);

//sendMessageService.sendBatch(webSessions, wsMessage);
//this.pushTelemetryData(device.getWorkspaceId(), data, device.getDeviceSn());
//        }
//        tsaService.handleOSD(receiver, device, webSessions, wsMessage);
//    }
}
