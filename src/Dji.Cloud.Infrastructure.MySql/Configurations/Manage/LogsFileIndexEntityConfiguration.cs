using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

namespace Dji.Cloud.Infrastructure.MySql.Configurations.Manage;

public class LogsFileIndexEntityConfiguration : IEntityTypeConfiguration<LogsFileIndexEntity>
{
    public void Configure(EntityTypeBuilder<LogsFileIndexEntity> builder)
    {
        builder.ToTable("logs_file_index", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.BootIndex).HasColumnName("boot_index");
        builder.Property(entity => entity.FileId).HasColumnName("file_id").HasMaxLength(64);
        builder.Property(entity => entity.Size).HasColumnName("size");
        builder.Property(entity => entity.StartTime).HasColumnName("start_time");
        builder.Property(entity => entity.EndTime).HasColumnName("end_time");
        builder.Property(entity => entity.DeviceSerialNumber).HasColumnName("device_sn").HasMaxLength(64);
        builder.Property(entity => entity.Domain).HasColumnName("domain");
        
        builder.Property(entity => entity.CreateTime).HasColumnName("create_time");
        builder.Property(entity => entity.UpdateTime).HasColumnName("update_time");
    }
}
