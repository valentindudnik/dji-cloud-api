using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MySql.Configurations.Manage;

public class DeviceHmsEntityConfiguration : IEntityTypeConfiguration<DeviceHmsEntity>
{
    public void Configure(EntityTypeBuilder<DeviceHmsEntity> builder)
    {
        builder.ToTable("manage_device_hms", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.HmsId).HasColumnName("hms_id").HasMaxLength(45);
        builder.Property(entity => entity.Tid).HasColumnName("tid").HasMaxLength(45);
        builder.Property(entity => entity.Bid).HasColumnName("bid").HasMaxLength(45);
        builder.Property(entity => entity.SerialNumber).HasColumnName("sn").HasMaxLength(45);
        builder.Property(entity => entity.Level).HasColumnName("level");
        builder.Property(entity => entity.Module).HasColumnName("module");
        builder.Property(entity => entity.HmsKey).HasColumnName("hms_key").HasMaxLength(64);
        builder.Property(entity => entity.MessageZh).HasColumnName("message_zh").HasMaxLength(100);
        builder.Property(entity => entity.MessageEn).HasColumnName("message_en").HasMaxLength(300);
        
        builder.Property(entity => entity.CreateTime).HasColumnName("create_time");
        builder.Property(entity => entity.UpdateTime).HasColumnName("update_time");
    }
}
