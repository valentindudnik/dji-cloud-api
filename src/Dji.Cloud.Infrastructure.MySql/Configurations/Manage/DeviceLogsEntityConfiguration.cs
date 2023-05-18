using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MySql.Configurations;

public class DeviceLogsEntityConfiguration : IEntityTypeConfiguration<DeviceLogsEntity>
{
    public void Configure(EntityTypeBuilder<DeviceLogsEntity> builder)
    {
        builder.ToTable("manage_device_logs", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.LogsId).HasColumnName("logs_id").HasMaxLength(45);
        builder.Property(entity => entity.UserName).HasColumnName("username").HasMaxLength(100);
        builder.Property(entity => entity.DeviceSerialNumber).HasColumnName("device_sn").HasMaxLength(45);
        builder.Property(entity => entity.LogsInfo).HasColumnName("logs_info").HasMaxLength(1000);
        builder.Property(entity => entity.HappenTime).HasColumnName("happen_time");
        builder.Property(entity => entity.Status).HasColumnName("status");
        
        builder.Property(entity => entity.CreateTime).HasColumnName("create_time");
        builder.Property(entity => entity.UpdateTime).HasColumnName("update_time");
    }
}
