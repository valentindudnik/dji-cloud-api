namespace Dji.Cloud.Application.Services.Manage;

public class AbstractTSAService
{
    protected AbstractTSAService tsaService;

    //@Autowired
    //protected ObjectMapper mapper;

    //@Autowired
    //private IWebSocketManageService webSocketManageService;

    //public AbstractTSAService(AbstractTSAService tsaService)
    //{
    //    this.tsaService = tsaService;
    //}

    //@Autowired
    //protected ISendMessageService sendMessageService;

    //@Override
    //public void pushTelemetryData(String workspaceId, Object osdData, String sn)
    //{
    //    // All connected accounts on the pilot side of this workspace.
    //    Collection<ConcurrentWebSocketSession> pilotSessions = webSocketManageService
    //            .getValueWithWorkspaceAndUserType(workspaceId, UserTypeEnum.PILOT.getVal());

    //    TelemetryDTO telemetry = TelemetryDTO.builder()
    //            .sn(sn)
    //            .build();
    //    CustomWebSocketMessage<TelemetryDTO> pilotMessage = CustomWebSocketMessage.< TelemetryDTO > builder()
    //            .timestamp(System.currentTimeMillis())
    //            .bizCode(BizCodeEnum.DEVICE_OSD.getCode())
    //            .data(telemetry)
    //            .build();

    //    this.pushTelemetryData(pilotSessions, pilotMessage, osdData);
    //}

    //public abstract void pushTelemetryData(Collection<ConcurrentWebSocketSession> sessions,
    //                                       CustomWebSocketMessage<TelemetryDTO> message, Object Object);

    //public abstract void handleOSD(CommonTopicReceiver receiver, DeviceDTO device,
    //                               Collection<ConcurrentWebSocketSession> webSessions, CustomWebSocketMessage<TelemetryDTO> wsMessage);

}
