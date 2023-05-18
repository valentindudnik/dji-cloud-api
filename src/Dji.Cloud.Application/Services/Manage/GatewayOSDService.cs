using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Services.Websocket;
using System.Collections.ObjectModel;

namespace Dji.Cloud.Application.Services.Manage;

public class GatewayOSDService //: IGatewayOSDService
{
//    public GatewayOSDServiceImpl(@Autowired @Qualifier("deviceOSDServiceImpl") AbstractTSAService tsaService) {
//        super(tsaService);
//}

//@Override
//    public void pushTelemetryData(Collection<ConcurrentWebSocketSession> sessions,
//                                  CustomWebSocketMessage<TelemetryDTO> message, Object osdData)
//{
//    if (osdData instanceof OsdGatewayReceiver) {
//        OsdGatewayReceiver data = (OsdGatewayReceiver)osdData;
//        TelemetryDTO telemetry = message.getData();
//        telemetry.setHost(TelemetryDeviceDTO.builder()
//                .latitude(data.getLatitude())
//                .longitude(data.getLongitude())
//                .build());
//        this.sendMessageService.sendBatch(sessions, message);
//        return;
//    }
//    tsaService.pushTelemetryData(sessions, message, osdData);
//}

//@Override
//    public void handleOSD(CommonTopicReceiver receiver, DeviceDTO device,
//                          Collection<ConcurrentWebSocketSession> webSessions,
//                          CustomWebSocketMessage<TelemetryDTO> wsMessage)
//{
//    if (DeviceDomainEnum.GATEWAY.getVal() == device.getDomain())
//    {

//        wsMessage.setBizCode(BizCodeEnum.GATEWAY_OSD.getCode());
//        OsdGatewayReceiver data = mapper.convertValue(receiver.getData(), OsdGatewayReceiver.class);
//            wsMessage.getData().setHost(data);

//            this.sendMessageService.sendBatch(webSessions, wsMessage);

//            this.pushTelemetryData(device.getWorkspaceId(), data, device.getDeviceSn());
//            return;
//}

//tsaService.handleOSD(receiver, device, webSessions, wsMessage);
//    }
}
