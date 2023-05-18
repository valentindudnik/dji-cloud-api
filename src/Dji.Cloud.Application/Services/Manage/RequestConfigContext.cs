using Dji.Cloud.Application.Abstracts.Interfaces.Wayline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Dji.Cloud.Application.Services.Manage;

public class RequestConfigContext
{
//    @Autowired
//    private IMessageSenderService messageSenderService;

//    @Autowired
//    private ObjectMapper objectMapper;


//    /**
//     * Handles the config method of the requests topic.
//     * @param receiver
//     * @param headers
//     */
//    @ServiceActivator(inputChannel = ChannelName.INBOUND_REQUESTS_CONFIG, outputChannel = ChannelName.OUTBOUND)
//    void handleConfig(CommonTopicReceiver receiver, MessageHeaders headers)
//    {
//        RequestConfigReceiver configReceiver = objectMapper.convertValue(receiver.getData(), RequestConfigReceiver.class);
//        Optional<ConfigScopeEnum> scopeEnumOpt = ConfigScopeEnum.find(configReceiver.getConfigScope());
//    String topic = headers.get(MqttHeaders.RECEIVED_TOPIC) + TopicConst._REPLY_SUF;
//    CommonTopicResponse.CommonTopicResponseBuilder<Object> build = CommonTopicResponse.builder()
//            .tid(receiver.getTid())
//            .bid(receiver.getBid())
//            .timestamp(System.currentTimeMillis())
//            .method(receiver.getMethod());
//        if (scopeEnumOpt.isEmpty()) {
//            messageSenderService.publish(topic, build.build());
//            return;
//        }

//IRequestsConfigService requestsConfigService = SpringBeanUtils.getBean(scopeEnumOpt.get().getClazz());
//build.data(requestsConfigService.getConfig());
//        messageSenderService.publish(topic, build.build());
//    }
}
