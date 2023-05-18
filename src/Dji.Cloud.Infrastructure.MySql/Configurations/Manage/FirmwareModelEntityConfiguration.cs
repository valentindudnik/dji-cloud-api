using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

namespace Dji.Cloud.Infrastructure.MySql.Configurations.Manage;

public class FirmwareModelEntityConfiguration : IEntityTypeConfiguration<FirmwareModelEntity>
{
    public void Configure(EntityTypeBuilder<FirmwareModelEntity> builder)
    {
        builder.ToTable("manage_firmware_model", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.FirmwareId).HasColumnName("firmware_id").HasMaxLength(64);
        builder.Property(entity => entity.DeviceName).HasColumnName("device_name").HasMaxLength(64);
        
        builder.Property(entity => entity.CreateTime).HasColumnName("create_time");
        builder.Property(entity => entity.UpdateTime).HasColumnName("update_time");
    }
}
