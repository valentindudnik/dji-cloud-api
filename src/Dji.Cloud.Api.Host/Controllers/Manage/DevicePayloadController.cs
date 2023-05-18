using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Microsoft.AspNetCore.Mvc;

namespace Dji.Cloud.Api.Host.Controllers.Manage;

[ApiController,
 Area("Manage"),
 Route("[area]/api/v{version:apiVersion}/[controller]")]
public class DevicePayloadController : ControllerBase
{
    private readonly IDevicePayloadService _service;

    public DevicePayloadController(IDevicePayloadService service)
    {
        _service = service;   
    }

    //    /**
    //     * Handles messages in the state topic about basic drone data.
    //     *
    //     * Note: Only the data of the drone payload is handled here. You can handle other data from the drone
    //     * according to your business needs.
    //     * @param deviceBasic   basic drone data
    //     * @param headers
    //     */
    //    @ServiceActivator(inputChannel = ChannelName.INBOUND_STATE_BASIC)
    //public void stateBasic(DeviceBasicReceiver deviceBasic, MessageHeaders headers)
    //    {

    //        devicePayloadService.saveDeviceBasicPayload(deviceBasic.getPayloads(), headers.getTimestamp());
    //    }
}
