using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Services.Manage;

public class CameraVideoService : ICameraVideoService
{
    //@Override
    //public CapacityVideoDTO receiver2Dto(CapacityVideoReceiver receiver)
    //{
    //    CapacityVideoDTO.CapacityVideoDTOBuilder builder = CapacityVideoDTO.builder();

    //    if (receiver != null)
    //    {
    //        builder.id(UUID.randomUUID().toString())
    //                .index(receiver.getVideoIndex())
    //                .type(receiver.getVideoType())
    //                .switchVideoTypes(receiver.getSwitchableVideoTypes());
    //    }
    //    return builder.build();
    //}
    public Task<CapacityVideo> ReceiverAsync(CapacityVideoReceiver receiver)
    {
        throw new NotImplementedException();
    }
}
