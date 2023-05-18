namespace Dji.Cloud.Domain.Websocket.Config;

public class WebSocketDefaultHandler
{
//    private IWebSocketManageService webSocketManageService;

//    WebSocketDefaultHandler(WebSocketHandler delegate, IWebSocketManageService webSocketManageService) {
//        super(delegate);
//        this.webSocketManageService = webSocketManageService;
//    }

//@Override
//    public void afterConnectionEstablished(WebSocketSession session) throws Exception
//{
//    Principal principal = session.getPrincipal();
//        if (StringUtils.hasText(principal.getName())) {
//        webSocketManageService.put(principal.getName(), new ConcurrentWebSocketSession(session));
//        log.debug("{} is connected. ID: {}. WebSocketSession[current count: {}]",
//                principal.getName(), session.getId(), webSocketManageService.getConnectedCount());
//        return;
//    }
//    session.close();
//}

//@Override
//    public void afterConnectionClosed(WebSocketSession session, CloseStatus closeStatus) throws Exception
//{
//    Principal principal = session.getPrincipal();
//        if (StringUtils.hasText(principal.getName())) {
//        webSocketManageService.remove(principal.getName(), session.getId());
//        log.debug("{} is disconnected. ID: {}. WebSocketSession[current count: {}]",
//                principal.getName(), session.getId(), webSocketManageService.getConnectedCount());
//    }

//}

//@Override
//    public void handleMessage(WebSocketSession session, WebSocketMessage<?> message) throws Exception
//{
//    log.debug("received message: {}", message.getPayload());
//}
}
