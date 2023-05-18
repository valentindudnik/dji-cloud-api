namespace Dji.Cloud.Domain.Websocket.Config;

public class ConcurrentWebSocketSession
{
    private const int SEND_BUFFER_SIZE_LIMIT = 1024 * 1024;

    private const int SEND_TIME_LIMIT = 1000;

//    private ConcurrentWebSocketSession(WebSocketSession delegate, int sendTimeLimit, int bufferSizeLimit) {
//        super(delegate, sendTimeLimit, bufferSizeLimit);
//}

//ConcurrentWebSocketSession(WebSocketSession delegate) {
//        this(delegate, SEND_TIME_LIMIT, SEND_BUFFER_SIZE_LIMIT);
//    }
}
