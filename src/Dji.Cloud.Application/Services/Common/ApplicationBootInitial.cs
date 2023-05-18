using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Services.Manage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dji.Cloud.Application.Services.Common
{
    public class ApplicationBootInitial
    {
    //    @Autowired
    //private IDeviceService deviceService;

    //    /**
    //     * Subscribe to the devices that exist in the redis when the program starts,
    //     * to prevent the data from being different from the pilot side due to program interruptions.
    //     * @param args
    //     * @throws Exception
    //     */
    //    @Override
    //public void run(String...args) throws Exception
    //    {
    //    int start = RedisConst.DEVICE_ONLINE_PREFIX.length();

    //    RedisOpsUtils.getAllKeys(RedisConst.DEVICE_ONLINE_PREFIX + "*")
    //            .forEach(key -> deviceService.subscribeTopicOnline(key.substring(start)));

    //}
}
}
