using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface IDeviceDictionaryService
{
    /// <summary>
    /// Query the type data of the device based on domain, device type and sub type.
    /// </summary>
    /// <param name="domain">domain</param>
    /// <param name="deviceType">device type</param>
    /// <param name="subType">sub type</param>
    /// <returns></returns>
    Task<DeviceDictionary> GetOneDictionaryInfoByTypeSubTypeAsync(int domain, int deviceType, int subType);
}
