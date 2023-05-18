using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;
using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Services.Manage;

public class CapacityCameraService : ICapacityCameraService
{
    //@Autowired
    //private ICameraVideoService cameraVideoService;

    //@Autowired
    //private IDeviceDictionaryService dictionaryService;

    //@Override
    //public List<CapacityCameraDTO> getCapacityCameraByDeviceSn(String deviceSn)
    //{
    //    return (List<CapacityCameraDTO>)RedisOpsUtils.hashGet(StateDataEnum.LIVE_CAPACITY.getDesc(), deviceSn);
    //}

    //@Override
    //public Boolean deleteCapacityCameraByDeviceSn(String deviceSn)
    //{
    //    return RedisOpsUtils.hashDel(StateDataEnum.LIVE_CAPACITY.getDesc(), new String[] { deviceSn });
    //}

    //@Override
    //public void saveCapacityCameraReceiverList(List<CapacityCameraReceiver> capacityCameraReceivers, String deviceSn, Long timestamp)
    //{
    //    List<CapacityCameraDTO> capacity = capacityCameraReceivers.stream()
    //            .map(this::receiver2Dto).collect(Collectors.toList());
    //    RedisOpsUtils.hashSet(StateDataEnum.LIVE_CAPACITY.getDesc(), deviceSn, capacity);
    //    RedisOpsUtils.setWithExpire(StateDataEnum.LIVE_CAPACITY + RedisConst.DELIMITER + deviceSn, timestamp, RedisConst.DEVICE_ALIVE_SECOND);
    //}

    //@Override
    //public CapacityCameraDTO receiver2Dto(CapacityCameraReceiver receiver)
    //{
    //    CapacityCameraDTO.CapacityCameraDTOBuilder builder = CapacityCameraDTO.builder();
    //    if (receiver == null)
    //    {
    //        return builder.build();
    //    }
    //    int[] indexArr = Arrays.stream(receiver.getCameraIndex().split("-"))
    //            .map(Integer::valueOf)
    //            .mapToInt(Integer::intValue)
    //            .toArray();
    //    // The cameraIndex consists of type and subType and the index of the payload hanging on the drone.
    //    // type-subType-index
    //    if (indexArr.length == 3)
    //    {
    //        Optional<DeviceDictionaryDTO> dictionaryOpt = dictionaryService
    //                .getOneDictionaryInfoByTypeSubType(DeviceDomainEnum.PAYLOAD.getVal(), indexArr[0], indexArr[1]);
    //        dictionaryOpt.ifPresent(dictionary->
    //                builder.name(dictionary.getDeviceName()));
    //    }
    //    return builder
    //            .id(UUID.randomUUID().toString())
    //            .videosList(receiver.getVideosList()
    //                    .stream()
    //                    .map(cameraVideoService::receiver2Dto)
    //                    .collect(Collectors.toList()))
    //            .index(receiver.getCameraIndex())
    //            .build();
    //}
    public Task<bool> DeleteCapacityCameraByDeviceSerialNumberAsync(string deviceSerialNumber)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CapacityCamera>> GetCapacityCameraByDeviceSerialNumberAsync(string deviceSerialNumber)
    {
        throw new NotImplementedException();
    }

    public Task<CapacityCamera> ReceiverAsync(CapacityCameraReceiver receiver)
    {
        throw new NotImplementedException();
    }

    public Task SaveCapacityCameraReceiverListAsync(IEnumerable<CapacityCameraReceiver> capacityCameraReceivers, string deviceSerialNumber, long timestamp)
    {
        throw new NotImplementedException();
    }
}
