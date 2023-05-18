using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Media;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations.Media;

public class MediaFileEntityConfiguration : IEntityTypeConfiguration<MediaFileEntity>
{
    public void Configure(EntityTypeBuilder<MediaFileEntity> builder)
    {
        builder.ToTable("MediaFiles", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.FileId).HasColumnName("FileId").HasMaxLength(64);
        builder.Property(entity => entity.FileName).HasColumnName("FileName").HasMaxLength(100);
        builder.Property(entity => entity.FilePath).HasColumnName("FilePath").HasMaxLength(100);
        builder.Property(entity => entity.WorkspaceId).HasColumnName("WorkspaceId").HasMaxLength(64);
        builder.Property(entity => entity.Fingerprint).HasColumnName("Fingerprint").HasMaxLength(64);
        builder.Property(entity => entity.TinnyFingerprint).HasColumnName("TinnyFingerprint").HasMaxLength(100);
        builder.Property(entity => entity.ObjectKey).HasColumnName("ObjectKey").HasMaxLength(1000);
        builder.Property(entity => entity.SubFileType).HasColumnName("SubFileType");
        builder.Property(entity => entity.IsOriginal).HasColumnName("IsOriginal");
        builder.Property(entity => entity.Drone).HasColumnName("Drone").HasMaxLength(32);
        builder.Property(entity => entity.Payload).HasColumnName("Payload").HasMaxLength(32);
        builder.Property(entity => entity.JobId).HasColumnName("JobId").HasMaxLength(64);
        builder.Property(entity => entity.JobId).HasColumnName("JobId").HasMaxLength(64);

        builder.Property(entity => entity.CreateTime).HasColumnName("CreateTime");
        builder.Property(entity => entity.UpdateTime).HasColumnName("UpdateTime");
    }
}
