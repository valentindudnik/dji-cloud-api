using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations.Manage;

public class LogsFileIndexEntityConfiguration : IEntityTypeConfiguration<LogsFileIndexEntity>
{
    public void Configure(EntityTypeBuilder<LogsFileIndexEntity> builder)
    {
        builder.ToTable("LogsFileIndexes", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.BootIndex).HasColumnName("BootIndex");
        builder.Property(entity => entity.FileId).HasColumnName("FileId").HasMaxLength(64);
        builder.Property(entity => entity.Size).HasColumnName("Size");
        builder.Property(entity => entity.StartTime).HasColumnName("StartTime");
        builder.Property(entity => entity.EndTime).HasColumnName("EndTime");
        builder.Property(entity => entity.DeviceSerialNumber).HasColumnName("DeviceSerialNumber").HasMaxLength(64);
        builder.Property(entity => entity.Domain).HasColumnName("Domain");
        
        builder.Property(entity => entity.CreateTime).HasColumnName("CreateTime");
        builder.Property(entity => entity.UpdateTime).HasColumnName("UpdateTime");
    }
}
