using Dji.Cloud.Application.Abstracts.Interfaces.Common;
using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Application.Abstracts.Interfaces.Wayline;
using Dji.Cloud.Application.Services.Common;
using Dji.Cloud.Application.Services.Manage;
using Dji.Cloud.Application.Services.Wayline;
using Microsoft.Extensions.DependencyInjection;

namespace Dji.Cloud.Infrastructure.Host.Configurations;

public static class ServicesConfiguration
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<IDeviceService, DeviceService>();
        services.AddScoped<IMediatorService, MediatorService>();
        services.AddScoped<IWorkspaceService, WorkspaceService>();
        services.AddScoped<IWaylineJobService, WaylineJobService>(); 
        services.AddScoped<IWaylineFileService, WaylineFileService>();
        services.AddScoped<IFirmwareModelService, FirmwareModelService>();
        services.AddScoped<IDeviceFirmwareService, DeviceFirmwareService>();
    }
}
