using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations.Manage;

public class LogsFileEntityConfiguration : IEntityTypeConfiguration<LogsFileEntity>
{
    public void Configure(EntityTypeBuilder<LogsFileEntity> builder)
    {
        builder.ToTable("LogsFiles", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.FileId).HasColumnName("FileId").HasMaxLength(45);
        builder.Property(entity => entity.Name).HasColumnName("Name").HasMaxLength(100);
        builder.Property(entity => entity.Size).HasColumnName("Size");
        builder.Property(entity => entity.LogsId).HasColumnName("LogsId").HasMaxLength(45);
        builder.Property(entity => entity.DeviceSerialNumber).HasColumnName("DeviceSerialNumber").HasMaxLength(45);
        builder.Property(entity => entity.Fingerprint).HasColumnName("Fingerprint").HasMaxLength(64);
        builder.Property(entity => entity.ObjectKey).HasColumnName("ObjectKey").HasMaxLength(1000);
        builder.Property(entity => entity.Status).HasColumnName("Status");

        builder.Property(entity => entity.CreateTime).HasColumnName("CreateTime");
        builder.Property(entity => entity.UpdateTime).HasColumnName("UpdateTime");
    }
}
