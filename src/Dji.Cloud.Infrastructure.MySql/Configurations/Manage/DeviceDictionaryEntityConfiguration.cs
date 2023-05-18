using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MySql.Configurations.Manage;

public class DeviceDictionaryEntityConfiguration : IEntityTypeConfiguration<DeviceDictionaryEntity>
{
    public void Configure(EntityTypeBuilder<DeviceDictionaryEntity> builder)
    {
        builder.ToTable("manage_device_dictionary", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.Domain).HasColumnName("domain");
        builder.Property(entity => entity.DeviceType).HasColumnName("device_type");
        builder.Property(entity => entity.SubType).HasColumnName("sub_type");
        builder.Property(entity => entity.DeviceName).HasColumnName("device_name").HasMaxLength(32);
        builder.Property(entity => entity.DeviceDesc).HasColumnName("device_desc").HasMaxLength(100);
    }
}
