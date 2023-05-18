using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Application.Abstracts.Responses.Common;
using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface IDeviceHmsService
{
    ///**
    //* Handle hms messages.
    //* @param receiver
    //* @param headers
    //*/
    //void handleHms(CommonTopicReceiver receiver, MessageHeaders headers);

    /// <summary>
    /// Query hms data by paging according to query parameters.
    /// </summary>
    /// <param name="request">the request</param>
    /// <returns>pagination data</returns>
    Task<PaginationResponse<DeviceHms>> GetDeviceHmsAsync(string workspaceId, DeviceHmsQueryRequest request);

    /// <summary>
    /// Read message handling.
    /// </summary>
    /// <param name="serialNumber">device serial number</param>
    /// <returns></returns>
    Task UpdateUnreadHmsAsync(string serialNumber);
}
