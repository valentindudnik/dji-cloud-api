using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface ICapacityCameraService
{
    /// <summary>
    /// Query all camera data that can be live streamed from this device based on the device sn.
    /// </summary>
    /// <param name="deviceSerialNumber">device serial number</param>
    /// <returns></returns>
    Task<IEnumerable<CapacityCamera>> GetCapacityCameraByDeviceSerialNumberAsync(string deviceSerialNumber);

    /// <summary>
    /// Delete all live capability data for this device based on the device sn.
    /// </summary>
    /// <param name="deviceSerialNumber">device serial number</param>
    /// <returns></returns>
    Task<bool> DeleteCapacityCameraByDeviceSerialNumberAsync(string deviceSerialNumber);

    /// <summary>
    /// Save the live capability data of the device.
    /// </summary>
    /// <param name="capacityCameraReceivers">capacityCameraReceivers</param>
    /// <param name="deviceSerialNumber">device serial number</param>
    /// <param name="timestamp">timestamp</param>
    /// <returns></returns>
    Task SaveCapacityCameraReceiverListAsync(IEnumerable<CapacityCameraReceiver> capacityCameraReceivers, string deviceSerialNumber, long timestamp);

    /// <summary>
    /// Convert the received camera capability object into camera data transfer object.
    /// </summary>
    /// <param name="receiver">receiver</param>
    /// <returns></returns>
    Task<CapacityCamera> ReceiverAsync(CapacityCameraReceiver receiver);
}
