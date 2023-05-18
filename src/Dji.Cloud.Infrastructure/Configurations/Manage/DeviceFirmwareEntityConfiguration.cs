using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations.Manage;

public class DeviceFirmwareEntityConfiguration : IEntityTypeConfiguration<DeviceFirmwareEntity>
{
    public void Configure(EntityTypeBuilder<DeviceFirmwareEntity> builder)
    {
        builder.ToTable("DeviceFirmwares", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.FirmwareId).HasColumnName("FirmwareId").HasMaxLength(45);
        builder.Property(entity => entity.FileName).HasColumnName("FileName").HasMaxLength(64);
        builder.Property(entity => entity.FirmwareVersion).HasColumnName("FirmwareVersion").HasMaxLength(45);
        builder.Property(entity => entity.ObjectKey).HasColumnName("ObjectKey").HasMaxLength(200);
        builder.Property(entity => entity.FileSize).HasColumnName("FileSize");
        builder.Property(entity => entity.FileMd5).HasColumnName("FileMd5").HasMaxLength(45);
        builder.Property(entity => entity.WorkspaceId).HasColumnName("WorkspaceId").HasMaxLength(64);
        builder.Property(entity => entity.ReleaseNote).HasColumnName("ReleaseNote").HasMaxLength(1000);
        builder.Property(entity => entity.ReleaseDate).HasColumnName("ReleaseDate");
        builder.Property(entity => entity.UserName).HasColumnName("UserName").HasMaxLength(64);
        builder.Property(entity => entity.Status).HasColumnName("Status");

        builder.Property(entity => entity.CreateTime).HasColumnName("CreateTime");
        builder.Property(entity => entity.UpdateTime).HasColumnName("UpdateTime");
    }
}
