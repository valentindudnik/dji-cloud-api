using Dji.Cloud.Application.Abstracts.Interfaces.Map;
using Dji.Cloud.Domain.Map;

namespace Dji.Cloud.Application.Services.Map;

public class GroupService : IGroupService
{
    //@Autowired
    //private IGroupMapper mapper;

    //@Autowired
    //private IGroupElementService groupElementService;

    //@Override
    //public List<GroupDTO> getAllGroupsByWorkspaceId(String workspaceId, String groupId, Boolean isDistributed)
    //{

    //    return mapper.selectList(
    //            new LambdaQueryWrapper<GroupEntity>()
    //                    .eq(GroupEntity::getWorkspaceId, workspaceId)
    //                    .eq(StringUtils.hasText(groupId), GroupEntity::getGroupId, groupId)
    //                    .eq(isDistributed != null, GroupEntity::getIsDistributed, isDistributed))
    //            .stream()
    //            .map(this::entityConvertToDto)
    //            .collect(Collectors.toList());
    //}

    ///**
    // * Convert database entity objects into group data transfer object.
    // * @param entity
    // * @return
    // */
    //private GroupDTO entityConvertToDto(GroupEntity entity)
    //{
    //    GroupDTO.GroupDTOBuilder builder = GroupDTO.builder();

    //    if (entity == null)
    //    {
    //        return builder.build();
    //    }

    //    return builder
    //            .id(entity.getGroupId())
    //            .name(entity.getGroupName())
    //            .type(entity.getGroupType())
    //            .isLock(entity.getIsLock())
    //            .isDistributed(entity.getIsDistributed())
    //            .createTime(entity.getCreateTime())
    //            .build();
    //}
    public Task<IEnumerable<Group>> GetAllGroupsByWorkspaceIdAsync(string workspaceId, string groupId, bool isDistributed)
    {
        throw new NotImplementedException();
    }
}
