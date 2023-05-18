using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Manage;
using Dji.Cloud.Domain.Mqtt.Models;
using Dji.Cloud.Domain.Websocket.Config;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface IDeviceService
{
    /// <summary>
    /// Bind devices to organizations and people
    /// </summary>
    /// <param name="serialNumber">serial number</param>
    /// <param name="device">device</param>
    /// <returns>status of binding</returns>
    Task<bool> BindDeviceAsync(string serialNumber, Device device);

    /// <summary>
    /// The device goes online
    /// </summary>
    /// <param name="statusGatewayReceiver">gateway</param>
    /// <returns>Whether the online is successful</returns>
    Task<bool> DeviceOnlineAsync(StatusGatewayRequest statusGatewayReceiver);

    /// <summary>
    /// The device goes offline
    /// </summary>
    /// <param name="statusGatewayReceiver">gateway</param>
    /// <returns> Whether the offline is successful</returns>
    Task<bool> DeviceOfflineAsync(StatusGatewayRequest statusGatewayReceiver);

    /// <summary>
    /// The aircraft goes offline
    /// </summary>
    /// <param name="serialNumber">aircraft's SN</param>
    /// <returns>Whether the offline is successful</returns>
    Task<bool> SubDeviceOfflineAsync(string serialNumber);

    /// <summary>
    /// When the device goes online, it needs to subscribe to topics.
    /// </summary>
    /// <param name="serialNumber">sn device's SN</param>
    Task SubscribeTopicOnlineAsync(string serialNumber);

    /// <summary>
    /// When the device goes offine, it needs to cancel the subscribed topics
    /// </summary>
    /// <param name="serialNumber">device's SN</param>
    /// <returns></returns>
    Task UnsubscribeTopicOfflineAsync(string serialNumber);

    /// <summary>
    /// Delete all device data according to the SN of the device
    /// </summary>
    /// <param name="ids">ids device's SN</param>
    /// <returns>status</returns>
    Task<bool> DeleteDeviceByDeviceSnsAsync(IEnumerable<string> ids);

    /// <summary>
    /// Obtain device data according to different query conditions
    /// </summary>
    /// <param name="request">query parameters</param>
    /// <returns>devices</returns>
    Task<IEnumerable<Device>> GetDevicesAsync(DeviceRequest request);

    /// <summary>
    /// When you receive a status topic message, you need to reply to it
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="serialNumber"> the target of serial number</param>
    /// <param name="commonTopicResponse"></param>
    /// <returns>response</returns>
    Task PublishStatusReplyAsync<TEntity>(string serialNumber, CommonTopicResponse<TEntity> commonTopicResponse) where TEntity: class;

    /// <summary>
    /// The business interface on the web side. Get all information about all devices in this workspace
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <returns></returns>
    Task<IEnumerable<Device>> GetDevicesAsync(string workspaceId);

    /// <summary>
    /// Set the remote controller and payloads information of the drone
    /// </summary>
    /// <param name="device">device</param>
    /// <returns></returns>
    Task SpliceDeviceAsync(Device device);

    /// <summary>
    /// Push the topology information to the pilot after one device is online
    /// </summary>
    /// <param name="sessions">The collection of connection objects on the pilot side</param>
    /// <param name="serialNumber">The serial number</param>
    /// <param name="gatewaySerialNumber">gateway serial number</param>
    /// <returns></returns>
    Task PushDeviceOnlineAsync(IEnumerable<ConcurrentWebSocketSession> sessions, string serialNumber, string gatewaySerialNumber);

    /// <summary>
    ///  Query the information of the device according to the sn of the device
    /// </summary>
    /// <param name="serialNumber">sn device sn</param>
    /// <returns>topology device</returns>
    Task<TopologyDevice?> GetDeviceTopologyAsync(string serialNumber);

    /// <summary>
    /// Convert individual device information into topology objects
    /// </summary>
    /// <param name="device">device</param>
    /// <returns>topology device</returns>
    Task<TopologyDevice> DeviceConvertToTopologyAsync(Device device);

    /// <summary>
    /// When the server receives the request of any device online, offline and topology update in the same workspace,
    /// it also broadcasts a push of device online, offline and topology update to PILOT via websocket,
    /// and PILOT will get the device topology list again after receiving the push
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="serialNumber">serial number</param>
    /// <returns></returns>
    Task PushDeviceOffliceTopologyAsync(string workspaceId, string serialNumber);

    /// <summary>
    /// When the server receives the request of any device online, offline and topology update in the same workspace,
    /// it also broadcasts a push of device online, offline and topology update to PILOT via websocket,
    /// and PILOT will get the device topology list again after receiving the push.
    /// </summary>
    /// <param name="workspaceId">workspace Id</param>
    /// <param name="gatewaySerialNumber">gateway serial number</param>
    /// <param name="deviceSerialNumber">device serial number</param>
    /// <returns></returns>
    Task PublishDeviceOnlineTopologyAsync(string workspaceId, string gatewaySerialNumber, string deviceSerialNumber);

    ///// <summary>
    ///// Handle messages from the osd topic
    ///// </summary>
    ///// <param name="message"></param>
    ///// <returns></returns>
    //Task HandleOsdAsync(Message<?> message);

    /// <summary>
    /// Update device
    /// </summary>
    /// <param name="device">device</param>
    /// <returns>status</returns>
    Task<bool> UpdateDeviceAsync(string workspaceId, string serialNumber, Device device);

    /// <summary>
    /// Bind devices to organizations and people
    /// </summary>
    /// <param name="device">device</param>
    /// <returns>status</returns>
    Task<bool> BindDeviceAsync(Device device);

    //Task BindStatusAsync<TEntity>(CommonTopicReceiver<TEntity> receiver, MessageHeaders headers);

    ///**
    // * Handle dock binding status requests.
    // * Note: If your business does not need to bind the dock to the organization,
    // *       you can directly reply to the successful message without implementing business logic.
    // * @param receiver
    // * @param headers
    // */
    //void bindStatus(CommonTopicReceiver receiver, MessageHeaders headers);

    ///**
    // * Handle dock binding requests.
    // * Note: If your business does not need to bind the dock to the organization,
    // *       you can directly reply to the successful message without implementing business logic.
    // * @param receiver
    // * @param headers
    // */
    //void bindDevice(CommonTopicReceiver receiver, MessageHeaders headers);

    Task<PaginationResponse<Device>> GetBoundDevicesWithDomainAsync(string workspaceId, long page, long pageSize, int domain);

    ///**
    // * Get the binding devices list in one workspace.
    // * @param workspaceId
    // * @param page
    // * @param pageSize
    // * @param domain
    // * @return
    // */
    //PaginationData<DeviceDTO> getBoundDevicesWithDomain(String workspaceId, Long page, Long pageSize, Integer domain);

    Task UnbindDeviceAsync(string deviceSerialNumber);

    ///**
    // * Unbind device base on device's sn.
    // * @param deviceSn
    // */
    //void unbindDevice(String deviceSn);

    Task<Device> GetDeviceAsync(string serialNumber);

    ///**
    // * Get device information based on device's sn.
    // * @param sn device's sn
    // * @return device
    // */
    //Optional<DeviceDTO> getDeviceBySn(String sn);

    Task UpdateFirmwareVersionAsync(FirmwareVersionReceiver receiver);

    ///**
    // * Update the firmware version information of the device or payload.
    // * @param receiver
    // */
    //void updateFirmwareVersion(FirmwareVersionReceiver receiver);

    Task CreateDeviceOtaJobAsync(string workspaceId, IEnumerable<DeviceFirmwareUpgrade> upgrades);

    Task<IEnumerable<Device>> GetDevicesTopoForWebAsync(string workspaceId);

    ///**
    // * Create job for device firmware updates.
    // * @param workspaceId
    // * @param upgradeDTOS
    // * @return 
    // */
    //ResponseResult createDeviceOtaJob(String workspaceId, List<DeviceFirmwareUpgradeDTO> upgradeDTOS);

    ///**
    // * Set the property parameters of the drone. 
    // * @param workspaceId
    // * @param dockSn
    // * @param propertyEnum
    // * @param param
    // */
    //void devicePropertySet(String workspaceId, String dockSn, DeviceSetPropertyEnum propertyEnum, JsonNode param);

    Task DeviceOnePropertySetAsync(string topic, DeviceSetProperties deviceSetProperties, IDictionary<string, object> values);

    ///**
    // * Set one property parameters of the drone.
    // * @param topic
    // * @param propertyEnum
    // * @param value
    // */
    //void deviceOnePropertySet(String topic, DeviceSetPropertyEnum propertyEnum, Map.Entry<String, Object> value);

    Task<bool> CheckDeviceOnlineAsync(string serialNumber);

    ///**
    // * Determine if the device is online.
    // * @param sn
    // * @return
    // */
    //Boolean checkDeviceOnline(String sn);
}
