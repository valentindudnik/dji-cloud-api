using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations;

public class DeviceLogsEntityConfiguration : IEntityTypeConfiguration<DeviceLogsEntity>
{
    public void Configure(EntityTypeBuilder<DeviceLogsEntity> builder)
    {
        builder.ToTable("DeviceLogs", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.LogsId).HasColumnName("LogsId").HasMaxLength(45);
        builder.Property(entity => entity.UserName).HasColumnName("UserName").HasMaxLength(100);
        builder.Property(entity => entity.DeviceSerialNumber).HasColumnName("DeviceSerialNumber").HasMaxLength(45);
        builder.Property(entity => entity.LogsInfo).HasColumnName("LogsInfo").HasMaxLength(1000);
        builder.Property(entity => entity.HappenTime).HasColumnName("HappenTime");
        builder.Property(entity => entity.Status).HasColumnName("Status");
        
        builder.Property(entity => entity.CreateTime).HasColumnName("CreateTime");
        builder.Property(entity => entity.UpdateTime).HasColumnName("UpdateTime");
    }
}
