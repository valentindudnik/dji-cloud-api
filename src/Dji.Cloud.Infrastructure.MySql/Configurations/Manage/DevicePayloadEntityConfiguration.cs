using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MySql.Configurations;

public class DevicePayloadEntityConfiguration : IEntityTypeConfiguration<DevicePayloadEntity>
{
    public void Configure(EntityTypeBuilder<DevicePayloadEntity> builder)
    {
        builder.ToTable("manage_device_payload", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.PayloadSerialNumber).HasColumnName("payload_sn").HasMaxLength(32);
        builder.Property(entity => entity.PayloadName).HasColumnName("payload_name").HasMaxLength(64);
        builder.Property(entity => entity.PayloadType).HasColumnName("payload_type");
        builder.Property(entity => entity.SubType).HasColumnName("sub_type");
        builder.Property(entity => entity.FirmwareVersion).HasColumnName("firmware_version").HasMaxLength(32);
        builder.Property(entity => entity.PayloadIndex).HasColumnName("payload_index");
        builder.Property(entity => entity.DeviceSerialNumber).HasColumnName("device_sn").HasMaxLength(32);
        builder.Property(entity => entity.PayloadDesc).HasColumnName("payload_desc").HasMaxLength(100);
        
        builder.Property(entity => entity.CreateTime).HasColumnName("create_time");
        builder.Property(entity => entity.UpdateTime).HasColumnName("update_time");
    }
}
