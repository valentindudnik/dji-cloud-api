using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations.Manage;

public class DeviceDictionaryEntityConfiguration : IEntityTypeConfiguration<DeviceDictionaryEntity>
{
    public void Configure(EntityTypeBuilder<DeviceDictionaryEntity> builder)
    {
        builder.ToTable("DeviceDictionaries", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.Domain).HasColumnName("Domain");
        builder.Property(entity => entity.DeviceType).HasColumnName("DeviceType");
        builder.Property(entity => entity.SubType).HasColumnName("SubType");
        builder.Property(entity => entity.DeviceName).HasColumnName("DeviceName").HasMaxLength(32);
        builder.Property(entity => entity.DeviceDesc).HasColumnName("DeviceDesc").HasMaxLength(100);
    }
}
