using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations.Manage;

public class DeviceEntityConfiguration : IEntityTypeConfiguration<DeviceEntity>
{
    public void Configure(EntityTypeBuilder<DeviceEntity> builder)
    {
        builder.ToTable("Devices", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.SerialNumber).HasColumnName("DeviceSerialNumber").HasMaxLength(32);
        builder.Property(entity => entity.DeviceName).HasColumnName("DeviceName").HasMaxLength(64);
        builder.Property(entity => entity.UserId).HasColumnName("UserId").HasMaxLength(64);
        builder.Property(entity => entity.NickName).HasColumnName("Nickname").HasMaxLength(64);
        builder.Property(entity => entity.WorkspaceId).HasColumnName("WorkspaceId").HasMaxLength(64);
        builder.Property(entity => entity.DeviceType).HasColumnName("DeviceType");
        builder.Property(entity => entity.SubType).HasColumnName("SubType");
        builder.Property(entity => entity.Domain).HasColumnName("Domain");
        builder.Property(entity => entity.FirmwareVersion).HasColumnName("FirmwareVersion").HasMaxLength(32);
        builder.Property(entity => entity.CompatibleStatus).HasColumnName("CompatibleStatus");
        builder.Property(entity => entity.Version).HasColumnName("Version").HasMaxLength(32);
        builder.Property(entity => entity.DeviceIndex).HasColumnName("DeviceIndex").HasMaxLength(32);
        builder.Property(entity => entity.ChildSerialNumber).HasColumnName("ChildSerialNumber").HasMaxLength(32);
        builder.Property(entity => entity.BoundTime).HasColumnName("BoundTime");
        builder.Property(entity => entity.BoundStatus).HasColumnName("BoundStatus");
        builder.Property(entity => entity.LoginTime).HasColumnName("LoginTime");
        builder.Property(entity => entity.DeviceDesc).HasColumnName("DeviceDesc").HasMaxLength(100);
        builder.Property(entity => entity.UrlNormal).HasColumnName("UrlNormal").HasMaxLength(200);
        builder.Property(entity => entity.UrlSelect).HasColumnName("UrlSelect").HasMaxLength(200);

        builder.Property(entity => entity.CreateTime).HasColumnName("CreateTime");
        builder.Property(entity => entity.UpdateTime).HasColumnName("UpdateTime");
    }
}
