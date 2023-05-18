using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface IDeviceFirmwareService
{
    /// <summary>
    /// Query specific firmware information based on the device model and firmware version.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="deviceName">device name</param>
    /// <param name="version">version</param>
    /// <returns>device firmware note</returns>
    Task<DeviceFirmware> GetFirmwareAsync(string workspaceId, string deviceName, string version);

    /// <summary>
    /// Get the latest firmware release note for this device model.
    /// </summary>
    /// <param name="deviceName">device name</param>
    /// <returns>device firmware note</returns>
    Task<DeviceFirmwareNote> GetLatestFirmwareReleaseNoteAsync(string deviceName);

    /// <summary>
    /// Get the firmware information that the device needs to update.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <param name="upgrades">upgrades</param>
    /// <returns></returns>
    Task<IEnumerable<DeviceOtaCreateRequest>> GetDeviceOtaFirmwareAsync(string workspaceId, IEnumerable<DeviceFirmwareUpgrade> upgrades);

    /// <summary>
    /// Query firmware version information by page.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="request">the request</param>
    /// <returns>the device's firmwares</returns>
    Task<PaginationResponse<DeviceFirmware>> GetFirmwaresAsync(string workspaceId, DeviceFirmwareQueryRequest request);

    /// <summary>
    /// Checks for file existence based on md5.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="fileMd5">the file Md5</param>
    /// <returns>the status</returns>
    Task<bool> CheckFileExistsAsync(string workspaceId, string fileMd5);

    /// <summary>
    /// Import firmware file for device upgrades.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="userName">the user name</param>
    /// <param name="request">the request</param>
    /// <param name="fileName">the file name</param>
    /// <param name="stream">the stream</param>
    /// <returns></returns>
    Task ImportFirmwareFileAsync(string workspaceId, string userName, DeviceFirmwareUpdateRequest request, string fileName, Stream stream);

    /// <summary>
    /// Save the file information of the firmware.
    /// </summary>
    /// <param name="deviceFirmware">the device firmware</param>
    /// <param name="deviceNames">the device names</param>
    /// <returns></returns>
    Task SaveFirmwareInfoAsync(DeviceFirmware deviceFirmware, IEnumerable<string> deviceNames);

    /// <summary>
    /// Update the file information of the firmware.
    /// </summary>
    /// <param name="workspaceId">the workspace id</param>
    /// <param name="firmwareId">the firmware id</param>
    /// <param name="request">the request</param>
    /// <returns></returns>
    Task UpdateFirmwareInfoAsync(string workspaceId, string firmwareId, DeviceFirmwareUpdateRequest request);

    ///**
    // * Interface to handle device firmware update progress.
    // * @param receiver
    // * @param headers
    // */
    //void handleOtaProgress(CommonTopicReceiver receiver, MessageHeaders headers);
}
