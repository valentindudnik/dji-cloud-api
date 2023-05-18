using AutoMapper;
using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Domain.Manage;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Dji.Cloud.Infrastructure.Abstracts.Interfaces;
using Microsoft.Extensions.Logging;

namespace Dji.Cloud.Application.Services.Manage;

public class WorkspaceService : IWorkspaceService
{
    private readonly IGenericRepository<WorkspaceEntity> _workspaceRepository;
    
    private readonly IMapper _mapper;
    private readonly ILogger<WorkspaceService> _logger;

    public WorkspaceService(IGenericRepository<WorkspaceEntity> workspaceRepository, 
                            IMapper mapper, 
                            ILogger<WorkspaceService> logger)
    {
        _workspaceRepository = workspaceRepository;

        _mapper = mapper;
        _logger = logger;
    }

    /// <summary>
    /// Get workspace by workspace id
    /// </summary>
    /// <param name="workspaceId">The workspace id</param>
    /// <returns>The workspace</returns>
    public async Task<Workspace> GetWorkspaceByWorkspaceIdAsync(string workspaceId)
    {
        _logger.LogInformation($"{nameof(GetWorkspaceByWorkspaceIdAsync)} was called with params: Workspace Id: {workspaceId}.");

        var workspaceEntity = await _workspaceRepository.FirstOrDefaultAsync(entity => entity.WorkspaceId == workspaceId);

        var workspace = _mapper.Map<Workspace>(workspaceEntity);

        _logger.LogInformation($"{nameof(GetWorkspaceByWorkspaceIdAsync)} was getting workspace with params: Workspace Id: {workspaceId}.");

        return workspace;
    }

    /// <summary>
    /// Get workspace by bind code
    /// </summary>
    /// <param name="bindCode">The bind code</param>
    /// <returns>The workspace</returns>
    public async Task<Workspace> GetWorkspaceByBindCodeAsync(string bindCode)
    {
        _logger.LogInformation($"{nameof(GetWorkspaceByBindCodeAsync)} was called with params: Bind Code: {bindCode}.");

        var workspaceEntity = await _workspaceRepository.FirstOrDefaultAsync(entity => entity.BindCode == bindCode);

        var workspace = _mapper.Map<Workspace>(workspaceEntity);

        _logger.LogInformation($"{nameof(GetWorkspaceByBindCodeAsync)} was getting workspace with params: Bind Code: {bindCode}.");

        return workspace;
    }

    //    @Override
    //    @ServiceActivator(inputChannel = ChannelName.INBOUND_REQUESTS_AIRPORT_ORGANIZATION_GET, outputChannel = ChannelName.OUTBOUND)
    //    public void replyOrganizationGet(CommonTopicReceiver receiver, MessageHeaders headers)
    //    {
    //        OrganizationGetReceiver organizationGet = objectMapper.convertValue(receiver.getData(), OrganizationGetReceiver.class);
    //        CommonTopicResponse.CommonTopicResponseBuilder<RequestsReply> builder = CommonTopicResponse.< RequestsReply > builder()
    //                .tid(receiver.getTid())
    //                .bid(receiver.getBid())
    //    .method(RequestsMethodEnum.AIRPORT_ORGANIZATION_GET.getMethod())
    //                .timestamp(System.currentTimeMillis());

    //    String topic = headers.get(MqttHeaders.RECEIVED_TOPIC).toString() + TopicConst._REPLY_SUF;

    //        if (!StringUtils.hasText(organizationGet.getDeviceBindingCode())) {
    //            builder.data(RequestsReply.error(CommonErrorEnum.ILLEGAL_ARGUMENT));
    //            messageSenderService.publish(topic, builder.build());
    //            return;
    //        }

    //Optional<WorkspaceDTO> workspace = this.getWorkspaceNameByBindCode(organizationGet.getDeviceBindingCode());
    //        if (workspace.isEmpty()) {
    //            builder.data(RequestsReply.error(CommonErrorEnum.GET_ORGANIZATION_FAILED));
    //            messageSenderService.publish(topic, builder.build());
    //            return;
    //        }

    //        builder.data(RequestsReply.success(Map.of(MapKeyConst.ORGANIZATION_NAME, workspace.get().getWorkspaceName())));
    //messageSenderService.publish(topic, builder.build());
    //    }
}
