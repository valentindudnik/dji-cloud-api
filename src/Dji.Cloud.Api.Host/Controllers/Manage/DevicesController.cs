using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Manage;
using Microsoft.AspNetCore.Mvc;

namespace Dji.Cloud.Api.Host.Controllers.Manage;

[ApiController,
 Area("Manage"),
 Route("[area]/api/v{version:apiVersion}/[controller]")]
public class DevicesController : ControllerBase
{
    private readonly IDeviceService _service;

    public DevicesController(IDeviceService service)
    {
        _service = service;
    }

    /// <summary>
    /// Get devices
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <returns></returns>
    [HttpGet("{workspaceId}/devices"),
     ProducesResponseType(typeof(IEnumerable<Device>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetDevicesAsync([FromRoute] string workspaceId)
    {
        var response = await _service.GetDevicesAsync(workspaceId);

        return Ok(response);
    }

    /// <summary>
    /// Bind device
    /// After binding the device to the workspace, the device data can only be seen on the web.
    /// </summary>
    /// <param name="serialNumber">serial number</param>
    /// <param name="device">device</param>
    /// <returns>status of binding</returns>
    [HttpPost("{serialNumber}/binding"),
     ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
    public async Task<IActionResult> BindDeviceAsync([FromRoute] string serialNumber, [FromBody] Device device)
    {
        var response = await _service.BindDeviceAsync(serialNumber, device);

        return Ok(response);
    }

    /// <summary>
    /// Get device
    /// Obtain device information according to device sn.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="serialNumber">serial number</param>
    /// <returns></returns>
    [HttpGet("{worksapceId}/devices/{serialNumber}"),
     ProducesResponseType(typeof(Device), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetDeviceAsync([FromRoute] string workspaceId, [FromRoute] string serialNumber)
    {
        var device = await _service.GetDeviceAsync(serialNumber);

        const string message = "Device is not found.";
        var response = device != null ? BaseResponse<Device>.Success(device) : BaseResponse<Device>.Error(message);

        return Ok(response);
    }

    /// <summary>
    /// Get the binding devices list in one workspace.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="request">the request</param>
    /// <returns></returns>
    [HttpGet("{workspaceId}/devices/bound"),
     ProducesResponseType(typeof(BaseResponse<PaginationResponse<Device>>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetBoundDevicesWithDomainAsync([FromRoute] string workspaceId, [FromBody] GetBoundDevicesRequest request) 
    {
        var devices = await _service.GetBoundDevicesWithDomainAsync(workspaceId, request.Page, request.PageSize, request.Domain);

        var response = BaseResponse<PaginationResponse<Device>>.Success(devices);

        return Ok(response);
    }

    /// <summary>
    /// Removing the binding state of the device.
    /// </summary>
    /// <param name="serialNumber">the serial number</param>
    /// <returns></returns>
    [HttpDelete("{serialNumber}/unbinding"),
     ProducesResponseType(typeof(BaseResponse<Device>), StatusCodes.Status200OK)]
    public async Task<IActionResult> UnbindingDeviceAsync([FromRoute] string serialNumber) 
    {
        await _service.UnbindDeviceAsync(serialNumber);

        var response = BaseResponse<Device>.Success();

        return Ok(response);
    }

    /// <summary>
    /// Update device information.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="serialNumber">the serial number</param>
    /// <param name="device">the device information</param>
    /// <returns></returns>
    [HttpPut("{workspaceId}/devices/{serialNumber}"),
     ProducesResponseType(typeof(BaseResponse<Device>), StatusCodes.Status200OK)]
    public async Task<IActionResult> UpdateDeviceAsync([FromRoute] string workspaceId, [FromRoute] string serialNumber, [FromBody] Device device)
    {
        var status = await _service.UpdateDeviceAsync(workspaceId, serialNumber, device);

        var response = status ? BaseResponse<Device>.Success() : BaseResponse<Device>.Error();

        return Ok(response);
    }

    [HttpPost("{workspaceId}/devices/ota")]
    public async Task<IActionResult> CreateOtaJobAsync([FromRoute] string workspaceId, [FromBody] IEnumerable<DeviceFirmwareUpgrade> upgrades)
    {
        // TODO:

        await _service.CreateDeviceOtaJobAsync(workspaceId, upgrades);

        return Ok();
    }

    [HttpPut("{workspaceId}/devices/{serialNumber}/property")]
    public async Task<IActionResult> DevicePropertySetAsync([FromRoute] string workspaceId, [FromRoute] string serialNumber)
    {
        // TODO:

        return Ok();
    }

    ///// <summary>
    ///// Get the topology list of all online devices in one workspace.
    ///// </summary>
    ///// <param name="workspaceId">the workspace id</param>
    ///// <returns></returns>
    //[HttpGet("{workspaceId}/devices")]
    //public async Task<IActionResult> GetDevicesTopoForWebAsync([FromRoute] string workspaceId)
    //{
    //    var devices = await _service.GetDevicesTopoForWebAsync(workspaceId);

    //    var response = BaseResponse<IEnumerable<Device>>.Success(devices);

    //    return Ok(response);
    //}

    ///**
    // * Delivers offline firmware upgrade tasks.
    // * @param workspaceId
    // * @param upgradeDTOS
    // * @return
    // */
    //@PostMapping("/{workspace_id}/devices/ota")
    //    public ResponseResult createOtaJob(@PathVariable("workspace_id") String workspaceId,
    //                                       @RequestBody List<DeviceFirmwareUpgradeDTO> upgradeDTOS) {
    //    return deviceService.createDeviceOtaJob(workspaceId, upgradeDTOS);
    //}

    ///**
    // * Set the property parameters of the drone.
    // * @param workspaceId
    // * @param dockSn
    // * @param param
    // * @return
    // */
    //@PutMapping("/{workspace_id}/devices/{device_sn}/property")
    //    public ResponseResult devicePropertySet(@PathVariable("workspace_id") String workspaceId,
    //                                            @PathVariable("device_sn") String dockSn,
    //                                            @RequestBody JsonNode param) {
    //    if (param.size() != 1)
    //    {
    //        return ResponseResult.error(CommonErrorEnum.ILLEGAL_ARGUMENT);
    //    }
    //    String property = param.fieldNames().next();
    //    Optional<DeviceSetPropertyEnum> propertyEnumOpt = DeviceSetPropertyEnum.find(property);
    //    if (propertyEnumOpt.isEmpty())
    //    {
    //        return ResponseResult.error(CommonErrorEnum.ILLEGAL_ARGUMENT);
    //    }
    //    deviceService.devicePropertySet(workspaceId, dockSn, propertyEnumOpt.get(), param.get(property));
    //    return ResponseResult.success();
    //}

    //    /**
    //     * Handles the message that the drone goes online.
    //     * @param receiver  The drone information is not empty.
    //     */
    //    @ServiceActivator(inputChannel = ChannelName.INBOUND_STATUS_ONLINE, outputChannel = ChannelName.OUTBOUND)
    //    public void deviceOnline(CommonTopicReceiver<StatusGatewayReceiver> receiver)
    //    {
    //        boolean online = deviceService.deviceOnline(receiver.getData());
    //        if (online)
    //        {
    //            // Notify pilot that the drone is online successfully.
    //            deviceService.publishStatusReply(receiver.getData().getSn(),
    //                    CommonTopicResponse.builder()
    //                            .tid(receiver.getTid())
    //                            .bid(receiver.getBid())
    //                            .timestamp(System.currentTimeMillis())
    //                            .method(receiver.getMethod())
    //                            .build());
    //        }
    //    }

    //    /**
    //     * Handles the message that the drone goes offline.
    //     * @param receiver  The drone information is empty.
    //     */
    //    @ServiceActivator(inputChannel = ChannelName.INBOUND_STATUS_OFFLINE, outputChannel = ChannelName.OUTBOUND)
    //    public void deviceOffline(CommonTopicReceiver<StatusGatewayReceiver> receiver)
    //    {

    //        boolean offline = deviceService.deviceOffline(receiver.getData());
    //        if (offline)
    //        {
    //            // Notify pilot that the device is offline successfully.
    //            deviceService.publishStatusReply(receiver.getData().getSn(),
    //                    CommonTopicResponse.builder()
    //                            .tid(receiver.getTid())
    //                            .bid(receiver.getBid())
    //                            .timestamp(System.currentTimeMillis())
    //                            .method(receiver.getMethod())
    //                            .build());

    //        }
    //    }
}
