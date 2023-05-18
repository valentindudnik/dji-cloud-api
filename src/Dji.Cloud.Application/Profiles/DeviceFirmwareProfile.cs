using AutoMapper;
using Dji.Cloud.Application.Abstracts.Requests.Manage;
using Dji.Cloud.Domain.Manage;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

namespace Dji.Cloud.Application.Profiles;

public class DeviceFirmwareProfile : Profile
{
    public DeviceFirmwareProfile()
    {
        CreateMap<DeviceFirmwareEntity, DeviceFirmware>()
            .ForMember(x => x.FileMd5, opt => opt.MapFrom(x => x.FileMd5))
            .ForMember(x => x.FileSize, opt => opt.MapFrom(x => x.FileSize))
            .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.UserName))
            .ForMember(x => x.FileName, opt => opt.MapFrom(x => x.FileName))
            .ForMember(x => x.ObjectKey, opt => opt.MapFrom(x => x.ObjectKey))
            .ForMember(x => x.FirmwareStatus, opt => opt.MapFrom(x => x.Status))
            .ForMember(x => x.FirmwareId, opt => opt.MapFrom(x => x.FirmwareId))
            .ForMember(x => x.WorkspaceId, opt => opt.MapFrom(x => x.WorkspaceId))
            .ForMember(x => x.ReleaseNote, opt => opt.MapFrom(x => x.ReleaseNote))
            .ForMember(x => x.ProductVersion, opt => opt.MapFrom(x => x.FirmwareVersion))
            .ForMember(x => x.ReleasedTime, opt => opt.MapFrom(x => DateTime.FromBinary(x.ReleaseDate)))
            .ForMember(x => x.DeviceName, opt => opt.MapFrom(x => x.DeviceName!.Split(",", StringSplitOptions.TrimEntries).ToArray()));

        CreateMap<DeviceFirmwareEntity, DeviceFirmwareNote>()
            .ForMember(x => x.DeviceName, opt => opt.MapFrom(x => x.DeviceName))
            .ForMember(x => x.ProductVersion, opt => opt.MapFrom(x => x.FirmwareVersion))
            .ForMember(x => x.ReleasedTime, opt => opt.MapFrom(x => DateTime.FromBinary(x.ReleaseDate)))
            .ForMember(x => x.ReleaseNote, opt => opt.MapFrom(x => x.ReleaseNote));

        CreateMap<DeviceFirmware, DeviceOtaCreateRequest>()
            .ForMember(x => x.FileSize, opt => opt.MapFrom(x => x.FileSize))
            .ForMember(x => x.FileName, opt => opt.MapFrom(x => x.FileName))
            .ForMember(x => x.Md5, opt => opt.MapFrom(x => x.FileMd5))
            .ForMember(x => x.ProductVersion, opt => opt.MapFrom(x => x.ProductVersion));

        CreateMap<DeviceFirmwareUpdateRequest, DeviceFirmware>()
            .ForMember(x => x.FileMd5, opt => opt.MapFrom(x => x.FileMd5))
            .ForMember(x => x.ProductVersion, opt => opt.MapFrom(x => x.ProductVersion))
            .ForMember(x => x.FirmwareStatus, opt => opt.MapFrom(x => x.FirmwareStatus))
            .ForMember(x => x.FirmwareId, opt => opt.MapFrom(x => x.FirmwareId))
            .ForMember(x => x.WorkspaceId, opt => opt.MapFrom(x => x.WorkspaceId))
            .ForMember(x => x.FileName, opt => opt.MapFrom(x => x.FileName))
            .ForMember(x => x.FileSize, opt => opt.MapFrom(x => x.FileSize))
            .ForMember(x => x.ObjectKey, opt => opt.MapFrom(x => x.ObjectKey))
            .ForMember(x => x.ReleaseNote, opt => opt.MapFrom(x => x.ReleaseNote))
            .ForMember(x => x.ReleasedTime, opt => opt.MapFrom(x => x.ReleasedTime))
            .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.UserName))
            .ForMember(x => x.DeviceName, opt => opt.MapFrom(x => x.DeviceName));

        CreateMap<DeviceFirmware, DeviceFirmwareEntity>()
            .ForMember(x => x.FileName, opt => opt.MapFrom(x => x.FileName))
            .ForMember(x => x.FileMd5, opt => opt.MapFrom(x => x.FileMd5))
            .ForMember(x => x.FileSize, opt => opt.MapFrom(x => x.FileSize))
            .ForMember(x => x.FirmwareId, opt => opt.MapFrom(x => x.FirmwareId))
            .ForMember(x => x.FirmwareVersion, opt => opt.MapFrom(x => x.ProductVersion))
            .ForMember(x => x.ObjectKey, opt => opt.MapFrom(x => x.ObjectKey))
            .ForMember(x => x.ReleaseDate, opt => opt.MapFrom(x => x.ReleasedTime))
            .ForMember(x => x.ReleaseNote, opt => opt.MapFrom(x => x.ReleaseNote))
            .ForMember(x => x.Status, opt => opt.MapFrom(x => x.FirmwareStatus))
            .ForMember(x => x.WorkspaceId, opt => opt.MapFrom(x => x.WorkspaceId))
            .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.UserName));

        CreateMap<DeviceFirmwareEntity, DeviceFirmwareEntity>()
            .ForMember(x => x.Id, opt => opt.Ignore())
            .ForMember(x => x.FileName, opt => opt.MapFrom(x => x.FileName))
            .ForMember(x => x.FileMd5, opt => opt.MapFrom(x => x.FileMd5))
            .ForMember(x => x.FileSize, opt => opt.MapFrom(x => x.FileSize))
            .ForMember(x => x.FirmwareId, opt => opt.MapFrom(x => x.FirmwareId))
            .ForMember(x => x.FirmwareVersion, opt => opt.MapFrom(x => x.FirmwareVersion))
            .ForMember(x => x.ObjectKey, opt => opt.MapFrom(x => x.ObjectKey))
            .ForMember(x => x.ReleaseDate, opt => opt.MapFrom(x => x.ReleaseDate))
            .ForMember(x => x.ReleaseNote, opt => opt.MapFrom(x => x.ReleaseNote))
            .ForMember(x => x.Status, opt => opt.MapFrom(x => x.Status))
            .ForMember(x => x.WorkspaceId, opt => opt.MapFrom(x => x.WorkspaceId))
            .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.UserName));
    }
}
