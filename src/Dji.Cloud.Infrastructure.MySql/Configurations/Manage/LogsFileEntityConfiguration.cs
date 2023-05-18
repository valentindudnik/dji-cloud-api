using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MySql.Configurations.Manage;

public class LogsFileEntityConfiguration : IEntityTypeConfiguration<LogsFileEntity>
{
    public void Configure(EntityTypeBuilder<LogsFileEntity> builder)
    {
        builder.ToTable("logs_file", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.FileId).HasColumnName("file_id").HasMaxLength(45);
        builder.Property(entity => entity.Name).HasColumnName("name").HasMaxLength(100);
        builder.Property(entity => entity.Size).HasColumnName("size");
        builder.Property(entity => entity.LogsId).HasColumnName("logs_id").HasMaxLength(45);
        builder.Property(entity => entity.DeviceSerialNumber).HasColumnName("device_sn").HasMaxLength(45);
        builder.Property(entity => entity.Fingerprint).HasColumnName("fingerprint").HasMaxLength(64);
        builder.Property(entity => entity.ObjectKey).HasColumnName("object_key").HasMaxLength(1000);
        builder.Property(entity => entity.Status).HasColumnName("status");

        builder.Property(entity => entity.CreateTime).HasColumnName("create_time");
        builder.Property(entity => entity.UpdateTime).HasColumnName("update_time");
    }
}
