using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Services.Manage;

public class DevicePayloadService : IDevicePayloadService
{
    //@Autowired
    //private IDevicePayloadMapper mapper;

    //@Autowired
    //private IDeviceDictionaryService dictionaryService;

    //@Autowired
    //private ICapacityCameraService capacityCameraService;

    //@Override
    //public Integer checkPayloadExist(String payloadSn)
    //{
    //    DevicePayloadEntity devicePayload = mapper.selectOne(
    //            new LambdaQueryWrapper<DevicePayloadEntity>()
    //                    .eq(DevicePayloadEntity::getPayloadSn, payloadSn));
    //    return devicePayload != null ? devicePayload.getId() : -1;
    //}

    //private Integer saveOnePayloadEntity(DevicePayloadEntity entity)
    //{
    //    int id = this.checkPayloadExist(entity.getPayloadSn());
    //    // If it already exists, update the data directly.
    //    if (id > 0)
    //    {
    //        entity.setId(id);
    //        return mapper.updateById(entity);
    //    }
    //    return mapper.insert(entity) > 0 ? entity.getId() : 0;
    //}

    //@Override
    //public Boolean savePayloadDTOs(List<DevicePayloadReceiver> payloadReceiverList)
    //{
    //    if (payloadReceiverList.isEmpty())
    //    {
    //        return true;
    //    }

    //    String deviceSn = payloadReceiverList.get(0).getDeviceSn();
    //    String key = RedisConst.DEVICE_ONLINE_PREFIX + deviceSn;
    //    DeviceDTO device = (DeviceDTO)RedisOpsUtils.get(key);
    //    List<DevicePayloadDTO> payloads = new ArrayList<>();

    //    for (DevicePayloadReceiver payloadReceiver : payloadReceiverList)
    //    {
    //        int payloadId = this.saveOnePayloadDTO(payloadReceiver);
    //        if (payloadId <= 0)
    //        {
    //            return false;
    //        }
    //        payloads.add(this.receiver2Dto(payloadReceiver));
    //    }

    //    if (payloads.isEmpty())
    //    {
    //        payloads = this.getDevicePayloadEntitiesByDeviceSn(deviceSn);
    //    }
    //    device.setPayloadsList(payloads);
    //    RedisOpsUtils.setWithExpire(RedisConst.DEVICE_ONLINE_PREFIX + device.getDeviceSn(), device, RedisConst.DEVICE_ALIVE_SECOND);
    //    return true;
    //}

    //@Override
    //public Integer saveOnePayloadDTO(DevicePayloadReceiver payloadReceiver)
    //{
    //    return this.saveOnePayloadEntity(payloadDTOConvertToEntity(payloadReceiver));
    //}

    //@Override
    //public List<DevicePayloadDTO> getDevicePayloadEntitiesByDeviceSn(String deviceSn)
    //{
    //    return mapper.selectList(
    //            new LambdaQueryWrapper<DevicePayloadEntity>()
    //                    .eq(DevicePayloadEntity::getDeviceSn, deviceSn))
    //            .stream()
    //            .map(this::payloadEntityConvertToDTO)
    //            .collect(Collectors.toList());
    //}

    //@Override
    //public void deletePayloadsByDeviceSn(List<String> deviceSns)
    //{
    //    deviceSns.forEach(deviceSn-> {
    //        mapper.delete(
    //                new LambdaQueryWrapper<DevicePayloadEntity>()
    //                        .eq(DevicePayloadEntity::getDeviceSn, deviceSn));
    //        capacityCameraService.deleteCapacityCameraByDeviceSn(deviceSn);
    //    });
    //}

    //@Override
    //public void updateFirmwareVersion(FirmwareVersionReceiver receiver)
    //{
    //    mapper.update(DevicePayloadEntity.builder()
    //                    .firmwareVersion(receiver.getFirmwareVersion())
    //    .build()
    //            , new LambdaUpdateWrapper<DevicePayloadEntity>()
    //                    .eq(DevicePayloadEntity::getDeviceSn, receiver.getSn()));
    //}

    //@Override
    //public void saveDeviceBasicPayload(List<DevicePayloadReceiver> payloadReceiverList, Long timestamp)
    //{
    //    if (payloadReceiverList.isEmpty())
    //    {
    //        return;
    //    }
    //    String deviceSn = payloadReceiverList.stream().findAny().get().getDeviceSn();
    //    String key = RedisConst.STATE_PAYLOAD_PREFIX + deviceSn;
    //    // Solve timing problems
    //    long last = (long)Objects.requireNonNullElse(RedisOpsUtils.get(key), 0L);
    //    if (last > timestamp)
    //    {
    //        return;
    //    }


    //    // Filter unsaved payload information.
    //    Set<String> payloadSns = this.getDevicePayloadEntitiesByDeviceSn(payloadReceiverList.get(0).getDeviceSn())
    //    .stream().map(DevicePayloadDTO::getPayloadSn).collect(Collectors.toSet());

    //    Set<String> newPayloadSns = payloadReceiverList.stream().map(DevicePayloadReceiver::getSn).collect(Collectors.toSet());
    //    Set<String> needToDel = payloadSns.stream().filter(sn-> !newPayloadSns.contains(sn)).collect(Collectors.toSet());
    //    this.deletePayloadsByPayloadsSn(needToDel);

    //    List<DevicePayloadReceiver> needToSave = payloadReceiverList.stream()
    //            .filter(payload-> !payloadSns.contains(payload.getSn())).collect(Collectors.toList());

    //    // Save the new payload information.
    //    boolean isSave = this.savePayloadDTOs(needToSave);
    //    if (isSave)
    //    {
    //        RedisOpsUtils.setWithExpire(key, timestamp, RedisConst.DEVICE_ALIVE_SECOND);
    //    }
    //    log.debug("The result of saving the payloads is {}.", isSave);
    //}

    //@Override
    //public void deletePayloadsByPayloadsSn(Collection<String> payloadSns)
    //{
    //    if (CollectionUtils.isEmpty(payloadSns))
    //    {
    //        return;
    //    }
    //    mapper.delete(new LambdaUpdateWrapper<DevicePayloadEntity>()
    //            .or(wrapper->payloadSns.forEach(sn->wrapper.eq(DevicePayloadEntity::getPayloadSn, sn))));
    //}

    ///**
    // * Convert database entity objects into payload data transfer object.
    // * @param entity
    // * @return
    // */
    //private DevicePayloadDTO payloadEntityConvertToDTO(DevicePayloadEntity entity)
    //{
    //    DevicePayloadDTO.DevicePayloadDTOBuilder builder = DevicePayloadDTO.builder();
    //    if (entity != null)
    //    {
    //        builder.payloadSn(entity.getPayloadSn())
    //                .payloadName(entity.getPayloadName())
    //                .payloadDesc(entity.getPayloadDesc())
    //                .payloadIndex(entity.getPayloadIndex());
    //    }
    //    return builder.build();
    //}

    ///**
    // * Convert the received payload object into a database entity object.
    // * @param dto   payload
    // * @return
    // */
    //private DevicePayloadEntity payloadDTOConvertToEntity(DevicePayloadReceiver dto)
    //{
    //    if (dto == null)
    //    {
    //        return new DevicePayloadEntity();
    //    }
    //    DevicePayloadEntity.DevicePayloadEntityBuilder builder = DevicePayloadEntity.builder();

    //    // The cameraIndex consists of type and subType and the index of the payload hanging on the drone.
    //    // type-subType-index
    //    String[] payloadIndexArr = dto.getPayloadIndex().split("-");
    //    try
    //    {
    //        int[] arr = Arrays.stream(payloadIndexArr)
    //                .map(Integer::valueOf)
    //                .mapToInt(Integer::intValue)
    //                .toArray();

    //        if (arr.length == 3)
    //        {
    //            Optional<DeviceDictionaryDTO> dictionaryOpt = dictionaryService
    //                    .getOneDictionaryInfoByTypeSubType(DeviceDomainEnum.PAYLOAD.getVal(), arr[0], arr[1]);
    //            dictionaryOpt.ifPresent(dictionary->
    //                    builder.payloadName(dictionary.getDeviceName())
    //                            .payloadDesc(dictionary.getDeviceDesc()));

    //        }
    //        builder.payloadType(arr[0])
    //                .subType(arr[1])
    //                .payloadIndex(arr[2]);
    //    }
    //    catch (NumberFormatException e)
    //    {
    //        builder.payloadType(Integer.valueOf(payloadIndexArr[0]))
    //                .subType(-1)
    //                .payloadIndex(Integer.valueOf(payloadIndexArr[2]));
    //    }

    //    return builder
    //            .payloadSn(dto.getSn())
    //            .deviceSn(dto.getDeviceSn())
    //            .build();
    //}

    //private DevicePayloadDTO receiver2Dto(DevicePayloadReceiver receiver)
    //{
    //    DevicePayloadDTO.DevicePayloadDTOBuilder builder = DevicePayloadDTO.builder();
    //    if (receiver == null)
    //    {
    //        return builder.build();
    //    }
    //    return builder.payloadSn(receiver.getSn())
    //            .payloadName(receiver.getPayloadIndex())
    //            .build();
    //}
    public Task<int> CheckPayloadExistAsync(string payloadSerialNumber)
    {
        throw new NotImplementedException();
    }

    public Task DeletePayloadsByDeviceSerialNumberAsync(IEnumerable<string> deviceSns)
    {
        throw new NotImplementedException();
    }

    public Task DeletePayloadsByPayloadsSerialNumberAsync(IEnumerable<string> payloadSns)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DevicePayload>> GetDevicePayloadEntitiesByDeviceSerialNumberAsync(string deviceSerialNumber)
    {
        throw new NotImplementedException();
    }

    public Task SaveDeviceBasicPayloadAsync(IEnumerable<DevicePayloadReceiver> payloadReceiverList, long timestamp)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveOnePayloadAsync(DevicePayloadReceiver payloadReceiver)
    {
        throw new NotImplementedException();
    }

    public Task<bool> SavePayloadAsync(IEnumerable<DevicePayloadReceiver> payloadReceiverList)
    {
        throw new NotImplementedException();
    }

    public Task UpdateFirmwareVersionAsync(FirmwareVersionReceiver receiver)
    {
        throw new NotImplementedException();
    }
}
