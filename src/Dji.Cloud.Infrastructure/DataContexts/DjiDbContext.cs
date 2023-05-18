using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Map;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Media;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Wayline;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Dji.Cloud.Infrastructure.MsSql.DataContexts;

public class DjiDbContext : DbContext
{
    public DjiDbContext(DbContextOptions<DjiDbContext> options) : base(options)
    {
        Database.SetCommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds);
    }

    public DbSet<DeviceDictionaryEntity> DeviceDictionaries { get; set; }
    public DbSet<DeviceEntity> Devices { get; set; }
    public DbSet<DeviceFirmwareEntity> DeviceFirmwares { get; set; }
    public DbSet<DeviceHmsEntity> DeviceHmses { get; set; }
    public DbSet<DeviceLogsEntity> DeviceLogs { get; set; }
    public DbSet<DevicePayloadEntity> DevicePayloads { get; set; }
    public DbSet<FirmwareModelEntity> FirmwareModels { get; set; }
    public DbSet<LogsFileEntity> LogsFiles { get; set; }
    public DbSet<LogsFileIndexEntity> LogsFileIndexes { get; set; }
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<WorkspaceEntity> Workspaces { get; set; }
    public DbSet<ElementCoordinateEntity> ElementCoordinates { get; set; }
    public DbSet<GroupElementEntity> GroupElements { get; set; }
    public DbSet<GroupEntity> Groups { get; set; }
    public DbSet<MediaFileEntity> MediaFiles { get; set; }
    public DbSet<WaylineFileEntity> WaylineFiles { get; set; }
    public DbSet<WaylineJobEntity> WaylineJobs { get; set; }

    public async Task<int> SaveChangesAsync()
    {
        return await SaveChangesAsync();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
