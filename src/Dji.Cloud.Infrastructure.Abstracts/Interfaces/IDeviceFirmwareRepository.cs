using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

namespace Dji.Cloud.Infrastructure.Abstracts.Interfaces;

public interface IDeviceFirmwareRepository
{
    Task<IEnumerable<DeviceFirmwareEntity>> GetDeviceFirmwaresAsync(string workspaceId, string deviceName, string version, long pageNumber, long pageSize);
    Task<DeviceFirmwareEntity> GetDeviceFirmwareAsync(string deviceName);
}
