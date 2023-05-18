using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations.Manage;

public class FirmwareModelEntityConfiguration : IEntityTypeConfiguration<FirmwareModelEntity>
{
    public void Configure(EntityTypeBuilder<FirmwareModelEntity> builder)
    {
        builder.ToTable("FirmwareModels", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.FirmwareId).HasColumnName("FirmwareId").HasMaxLength(64);
        builder.Property(entity => entity.DeviceName).HasColumnName("DeviceName").HasMaxLength(64);
        
        builder.Property(entity => entity.CreateTime).HasColumnName("CreateTime");
        builder.Property(entity => entity.UpdateTime).HasColumnName("UpdateTime");
    }
}
