using Dji.Cloud.Application.Abstracts.Interfaces.Storage;
using Dji.Cloud.Domain.Media;

namespace Dji.Cloud.Application.Services.Storage;

public class StorageService : IStorageService
{
    //@Autowired
    //private IMessageSenderService messageSender;

    //@Autowired
    //private OssServiceContext ossService;

    //@Override
    //public StsCredentialsDTO getSTSCredentials()
    //{
    //    return StsCredentialsDTO.builder()
    //            .endpoint(OssConfiguration.endpoint)
    //            .bucket(OssConfiguration.bucket)
    //            .credentials(ossService.getCredentials())
    //            .provider(OssConfiguration.provider)
    //            .objectKeyPrefix(OssConfiguration.objectDirPrefix)
    //            .region(OssConfiguration.region)
    //            .build();
    //}

    //@Override
    //@ServiceActivator(inputChannel = ChannelName.INBOUND_REQUESTS_STORAGE_CONFIG_GET, outputChannel = ChannelName.OUTBOUND)
    //public void replyConfigGet(CommonTopicReceiver receiver, MessageHeaders headers)
    //{
    //    CommonTopicResponse<RequestsReply> response = CommonTopicResponse.< RequestsReply > builder()
    //            .tid(receiver.getTid())
    //            .bid(receiver.getBid())
    //            .data(RequestsReply.success(this.getSTSCredentials()))
    //            .timestamp(System.currentTimeMillis())
    //            .method(receiver.getMethod())
    //            .build();
    //    messageSender.publish(headers.get(MqttHeaders.RECEIVED_TOPIC) + TopicConst._REPLY_SUF, response);
    //}
    public Task<StsCredentials> GetStsCredentialsAsync(string workspaceId)
    {
        throw new NotImplementedException();
    }
}
