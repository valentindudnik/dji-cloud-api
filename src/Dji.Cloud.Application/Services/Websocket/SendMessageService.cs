using Dji.Cloud.Application.Abstracts.Interfaces.Websocket;
using Dji.Cloud.Domain.Websocket.Config;
using Dji.Cloud.Domain.Websocket.Models;
using System.Collections.ObjectModel;

namespace Dji.Cloud.Application.Services.Websocket;

public class SendMessageService : ISendMessageService
{
    //@Autowired
    //private ObjectMapper mapper;

    //@Override
    //public void sendMessage(ConcurrentWebSocketSession session, CustomWebSocketMessage message)
    //{
    //    if (session == null)
    //    {
    //        return;
    //    }

    //    try
    //    {
    //        if (!session.isOpen())
    //        {
    //            session.close();
    //            log.debug("This session is closed.");
    //            return;
    //        }


    //        session.sendMessage(new TextMessage(mapper.writeValueAsBytes(message)));
    //    }
    //    catch (IOException e)
    //    {
    //        log.info("Failed to publish the message. {}", message.toString());
    //        e.printStackTrace();
    //    }
    //}

    //@Override
    //public void sendBatch(Collection<ConcurrentWebSocketSession> sessions, CustomWebSocketMessage message)
    //{
    //    if (sessions.isEmpty())
    //    {
    //        return;
    //    }

    //    try
    //    {

    //        TextMessage data = new TextMessage(mapper.writeValueAsBytes(message));

    //        for (ConcurrentWebSocketSession session : sessions)
    //        {
    //            if (!session.isOpen())
    //            {
    //                session.close();
    //                log.debug("This session is closed.");
    //                return;
    //            }
    //            session.sendMessage(data);
    //        }

    //    }
    //    catch (IOException e)
    //    {
    //        log.info("Failed to publish the message. {}", message.toString());

    //        e.printStackTrace();
    //    }
    //}
    public Task SendBatchAsync<TEntity>(Collection<ConcurrentWebSocketSession> sessions, CustomWebSocketMessage<TEntity> message) where TEntity : class
    {
        throw new NotImplementedException();
    }

    public Task SendMessageAsync<TEntity>(ConcurrentWebSocketSession session, CustomWebSocketMessage<TEntity> message) where TEntity : class
    {
        throw new NotImplementedException();
    }
}
