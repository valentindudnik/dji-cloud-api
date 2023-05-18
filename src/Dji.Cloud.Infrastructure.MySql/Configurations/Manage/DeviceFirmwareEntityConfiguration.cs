using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MySql.Configurations.Manage;

public class DeviceFirmwareEntityConfiguration : IEntityTypeConfiguration<DeviceFirmwareEntity>
{
    public void Configure(EntityTypeBuilder<DeviceFirmwareEntity> builder)
    {
        builder.ToTable("manage_device_firmware", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.FirmwareId).HasColumnName("firmware_id").HasMaxLength(45);
        builder.Property(entity => entity.FileName).HasColumnName("file_name").HasMaxLength(64);
        builder.Property(entity => entity.FirmwareVersion).HasColumnName("firmware_version").HasMaxLength(45);
        builder.Property(entity => entity.ObjectKey).HasColumnName("object_key").HasMaxLength(200);
        builder.Property(entity => entity.FileSize).HasColumnName("file_size");
        builder.Property(entity => entity.FileMd5).HasColumnName("file_md5").HasMaxLength(45);
        builder.Property(entity => entity.WorkspaceId).HasColumnName("workspace_id").HasMaxLength(64);
        builder.Property(entity => entity.ReleaseNote).HasColumnName("release_note").HasMaxLength(1000);
        builder.Property(entity => entity.ReleaseDate).HasColumnName("release_date");
        builder.Property(entity => entity.UserName).HasColumnName("user_name").HasMaxLength(64);
        builder.Property(entity => entity.Status).HasColumnName("status");

        builder.Property(entity => entity.CreateTime).HasColumnName("create_time");
        builder.Property(entity => entity.UpdateTime).HasColumnName("update_time");
    }
}
