using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface IFirmwareModelService
{
    /// <summary>
    /// Save the relationship between firmware files and device models.
    /// </summary>
    /// <param name="firmwareModel"></param>
    /// <returns></returns>
    Task SaveFirmwareDeviceNameAsync(FirmwareModel firmwareModel);
}
