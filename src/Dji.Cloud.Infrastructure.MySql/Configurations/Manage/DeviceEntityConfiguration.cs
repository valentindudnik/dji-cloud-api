using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dji.Cloud.Infrastructure.MySql.Configurations.Manage;

public class DeviceEntityConfiguration : IEntityTypeConfiguration<DeviceEntity>
{
    public void Configure(EntityTypeBuilder<DeviceEntity> builder)
    {
        builder.ToTable("manage_device", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.SerialNumber).HasColumnName("device_sn").HasMaxLength(32);
        builder.Property(entity => entity.DeviceName).HasColumnName("device_name").HasMaxLength(64);
        builder.Property(entity => entity.UserId).HasColumnName("user_id").HasMaxLength(64);
        builder.Property(entity => entity.NickName).HasColumnName("nickname").HasMaxLength(64);
        builder.Property(entity => entity.WorkspaceId).HasColumnName("workspace_id").HasMaxLength(64);
        builder.Property(entity => entity.DeviceType).HasColumnName("device_type");
        builder.Property(entity => entity.SubType).HasColumnName("sub_type");
        builder.Property(entity => entity.Domain).HasColumnName("domain");
        builder.Property(entity => entity.FirmwareVersion).HasColumnName("firmware_version").HasMaxLength(32);
        builder.Property(entity => entity.CompatibleStatus).HasColumnName("compatible_status");
        builder.Property(entity => entity.Version).HasColumnName("version").HasMaxLength(32);
        builder.Property(entity => entity.DeviceIndex).HasColumnName("device_index").HasMaxLength(32);
        builder.Property(entity => entity.ChildSerialNumber).HasColumnName("child_sn").HasMaxLength(32);
        builder.Property(entity => entity.BoundTime).HasColumnName("bound_time");
        builder.Property(entity => entity.BoundStatus).HasColumnName("bound_status");
        builder.Property(entity => entity.LoginTime).HasColumnName("login_time");
        builder.Property(entity => entity.DeviceDesc).HasColumnName("device_desc").HasMaxLength(100);
        builder.Property(entity => entity.UrlNormal).HasColumnName("url_normal").HasMaxLength(200);
        builder.Property(entity => entity.UrlSelect).HasColumnName("url_select").HasMaxLength(200);

        builder.Property(entity => entity.CreateTime).HasColumnName("create_time");
        builder.Property(entity => entity.UpdateTime).HasColumnName("update_time");
    }
}
