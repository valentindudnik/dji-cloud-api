using Dji.Cloud.Domain.Manage;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface IDevicePayloadService
{
    /// <summary>
    /// Query if the payload has been saved based on the sn of the payload.
    /// </summary>
    /// <param name="payloadSerialNumber">payload serial number</param>
    /// <returns></returns>
    Task<int> CheckPayloadExistAsync(string payloadSerialNumber);

    /// <summary>
    /// Save all payload data.
    /// </summary>
    /// <param name="payloadReceiverList">payloadReceiverList</param>
    /// <returns></returns>
    Task<bool> SavePayloadAsync(IEnumerable<DevicePayloadReceiver> payloadReceiverList);

    /// <summary>
    /// Save a payload data.
    /// </summary>
    /// <param name="payloadReceiver">payload receiver</param>
    /// <returns></returns>
    Task<int> SaveOnePayloadAsync(DevicePayloadReceiver payloadReceiver);

    /// <summary>
    /// Query all payload data on this device based on the device sn.
    /// </summary>
    /// <param name="deviceSerialNumber">device serial number</param>
    /// <returns></returns>
    Task<IEnumerable<DevicePayload>> GetDevicePayloadEntitiesByDeviceSerialNumberAsync(string deviceSerialNumber);

    /// <summary>
    /// Delete all payload data on these devices based on the collection of device sns.
    /// </summary>
    /// <param name="deviceSns">device sns</param>
    /// <returns></returns>
    Task DeletePayloadsByDeviceSerialNumberAsync(IEnumerable<string> deviceSns);

    /// <summary>
    /// Update the firmware version information of the payload.
    /// </summary>
    /// <param name="receiver">receiver</param>
    /// <returns></returns>
    Task UpdateFirmwareVersionAsync(FirmwareVersionReceiver receiver);

    /// <summary>
    /// Handle the topic that contains the payloads field in the state, and save the payloads data.
    /// </summary>
    /// <param name="payloadReceiverList">payload receiver list</param>
    /// <param name="timestamp">timestamp</param>
    /// <returns></returns>
    Task SaveDeviceBasicPayloadAsync(IEnumerable<DevicePayloadReceiver> payloadReceiverList, long timestamp);

    /// <summary>
    /// Delete payload data based on payload sn.
    /// </summary>
    /// <returns></returns>
    Task DeletePayloadsByPayloadsSerialNumberAsync(IEnumerable<string> payloadSns);
}
