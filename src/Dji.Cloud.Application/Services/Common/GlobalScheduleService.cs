namespace Dji.Cloud.Application.Services.Common;

internal class GlobalScheduleService
{
//    @Autowired
//private IDeviceService deviceService;

//    @Autowired
//private IMqttTopicService topicService;

//    @Autowired
//private IWaylineJobService waylineJobService;

//    /**
//     * Check the status of the devices every 30 seconds. It is recommended to use cache.
//     */
//    @Scheduled(initialDelay = 30, fixedRate = 30, timeUnit = TimeUnit.SECONDS)
//private void deviceStatusListen()
//    {
//        int start = RedisConst.DEVICE_ONLINE_PREFIX.length();

//        RedisOpsUtils.getAllKeys(RedisConst.DEVICE_ONLINE_PREFIX + "*").forEach(key-> {
//            long expire = RedisOpsUtils.getExpire(key);
//            if (expire <= 30)
//            {
//                DeviceDTO device = (DeviceDTO)RedisOpsUtils.get(key);
//                if (DeviceDomainEnum.SUB_DEVICE.getVal() == device.getDomain())
//                {
//                    deviceService.subDeviceOffline(key.substring(start));
//                }
//                else
//                {
//                    deviceService.unsubscribeTopicOffline(key.substring(start));
//                    deviceService.pushDeviceOfflineTopo(device.getWorkspaceId(), device.getDeviceSn());
//                    RedisOpsUtils.hashDel(RedisConst.LIVE_CAPACITY, new String[] { key });
//                    RedisOpsUtils.del(RedisConst.HMS_PREFIX + key);
//                }
//                RedisOpsUtils.del(key);
//            }
//        });

//        log.info("Subscriptions: {}", Arrays.toString(topicService.getSubscribedTopic()));
//    }
}
