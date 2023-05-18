using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Dji.Cloud.Infrastructure.Abstracts.Interfaces;
using Dji.Cloud.Infrastructure.MySql.DataContexts;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MySql.Repositories;

public class DeviceFirmwareRepository : IDeviceFirmwareRepository
{
    private readonly DjiDbContext _dbContext;

    public DeviceFirmwareRepository(DjiDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<DeviceFirmwareEntity>> GetDeviceFirmwaresAsync(string workspaceId, string deviceName, string version, long pageNumber, long pageSize)
    {
        var result = await (from deviceFirmware in _dbContext.DeviceFirmwares
                            join firmwareModel in _dbContext.FirmwareModels on deviceFirmware.FirmwareId equals firmwareModel.FirmwareId
                            where deviceFirmware.Status && deviceFirmware.WorkspaceId == workspaceId &&
                                  !string.IsNullOrWhiteSpace(firmwareModel.DeviceName) &&
                                  !string.IsNullOrWhiteSpace(deviceFirmware.FirmwareVersion) &&
                                  EF.Functions.Like(firmwareModel.DeviceName, $"%{deviceName}%") &&
                                  EF.Functions.Like(deviceFirmware.FirmwareVersion, $"%{version}%")
                            select new DeviceFirmwareEntity
                            {
                                Id = deviceFirmware.Id,
                                CreateTime = deviceFirmware.CreateTime,
                                DeviceName = firmwareModel.DeviceName,
                                FirmwareId = deviceFirmware.FirmwareId,
                                ObjectKey = deviceFirmware.ObjectKey,
                                FileName = deviceFirmware.FileName,
                                FirmwareVersion = deviceFirmware.FirmwareVersion,
                                WorkspaceId = deviceFirmware.WorkspaceId,
                                UserName = deviceFirmware.UserName,
                                ReleaseDate = deviceFirmware.ReleaseDate,
                                UpdateTime = deviceFirmware.UpdateTime,
                                Status = deviceFirmware.Status,
                                ReleaseNote = deviceFirmware.ReleaseNote,
                                FileSize = deviceFirmware.FileSize,
                                FileMd5 = deviceFirmware.FileMd5
                            }).OrderByDescending(entity => entity.ReleaseDate)
                              .ToArrayAsync();
        return result!;
    }

    public async Task<DeviceFirmwareEntity> GetDeviceFirmwareAsync(string deviceName)
    {
        var result = await (from deviceFirmware in _dbContext.DeviceFirmwares
                                          join firmwareModel in _dbContext.FirmwareModels on deviceFirmware.FirmwareId equals firmwareModel.FirmwareId
                                          where deviceFirmware.Status && !string.IsNullOrWhiteSpace(firmwareModel.DeviceName) &&
                                                EF.Functions.Like(firmwareModel.DeviceName, $"%{deviceName}%")
                                          select new DeviceFirmwareEntity
                                          {
                                              Id = deviceFirmware.Id,
                                              CreateTime = deviceFirmware.CreateTime,
                                              DeviceName = firmwareModel.DeviceName,
                                              FirmwareId = deviceFirmware.FirmwareId,
                                              ObjectKey = deviceFirmware.ObjectKey,
                                              FileName = deviceFirmware.FileName,
                                              FirmwareVersion = deviceFirmware.FirmwareVersion,
                                              WorkspaceId = deviceFirmware.WorkspaceId,
                                              UserName = deviceFirmware.UserName,
                                              ReleaseDate = deviceFirmware.ReleaseDate,
                                              UpdateTime = deviceFirmware.UpdateTime,
                                              Status = deviceFirmware.Status,
                                              ReleaseNote = deviceFirmware.ReleaseNote,
                                              FileSize = deviceFirmware.FileSize,
                                              FileMd5 = deviceFirmware.FileMd5
                                          }).OrderByDescending(entity => entity.ReleaseDate)
                                               .ThenByDescending(entity => entity.FirmwareVersion)
                                               .FirstOrDefaultAsync();
        return result!;
    }
}
