using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations.Manage;

public class DeviceHmsEntityConfiguration : IEntityTypeConfiguration<DeviceHmsEntity>
{
    public void Configure(EntityTypeBuilder<DeviceHmsEntity> builder)
    {
        builder.ToTable("DeviceHmses", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.HmsId).HasColumnName("HmsId").HasMaxLength(45);
        builder.Property(entity => entity.Tid).HasColumnName("Tid").HasMaxLength(45);
        builder.Property(entity => entity.Bid).HasColumnName("Bid").HasMaxLength(45);
        builder.Property(entity => entity.SerialNumber).HasColumnName("SerialNumber").HasMaxLength(45);
        builder.Property(entity => entity.Level).HasColumnName("Level");
        builder.Property(entity => entity.Module).HasColumnName("Module");
        builder.Property(entity => entity.HmsKey).HasColumnName("HmsKey").HasMaxLength(64);
        builder.Property(entity => entity.MessageZh).HasColumnName("MessageZh").HasMaxLength(100);
        builder.Property(entity => entity.MessageEn).HasColumnName("MessageEn").HasMaxLength(300);
        
        builder.Property(entity => entity.CreateTime).HasColumnName("CreateTime");
        builder.Property(entity => entity.UpdateTime).HasColumnName("UpdateTime");
    }
}
