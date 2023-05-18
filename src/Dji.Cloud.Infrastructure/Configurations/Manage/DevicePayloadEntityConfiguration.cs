using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations;

public class DevicePayloadEntityConfiguration : IEntityTypeConfiguration<DevicePayloadEntity>
{
    public void Configure(EntityTypeBuilder<DevicePayloadEntity> builder)
    {
        builder.ToTable("DevicePayloads", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.PayloadSerialNumber).HasColumnName("PayloadSerialNumber").HasMaxLength(32);
        builder.Property(entity => entity.PayloadName).HasColumnName("PayloadName").HasMaxLength(64);
        builder.Property(entity => entity.PayloadType).HasColumnName("PayloadType");
        builder.Property(entity => entity.SubType).HasColumnName("SubType");
        builder.Property(entity => entity.FirmwareVersion).HasColumnName("FirmwareVersion").HasMaxLength(32);
        builder.Property(entity => entity.PayloadIndex).HasColumnName("PayloadIndex");
        builder.Property(entity => entity.DeviceSerialNumber).HasColumnName("DeviceSerialNumber").HasMaxLength(32);
        builder.Property(entity => entity.PayloadDesc).HasColumnName("PayloadDesc").HasMaxLength(100);
        
        builder.Property(entity => entity.CreateTime).HasColumnName("CreateTime");
        builder.Property(entity => entity.UpdateTime).HasColumnName("UpdateTime");
    }
}
