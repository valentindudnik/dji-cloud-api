using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Media;

namespace Dji.Cloud.Infrastructure.MySql.Configurations.Media;

public class MediaFileEntityConfiguration : IEntityTypeConfiguration<MediaFileEntity>
{
    public void Configure(EntityTypeBuilder<MediaFileEntity> builder)
    {
        builder.ToTable("media_file", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.FileId).HasColumnName("file_id").HasMaxLength(64);
        builder.Property(entity => entity.FileName).HasColumnName("file_name").HasMaxLength(100);
        builder.Property(entity => entity.FilePath).HasColumnName("file_path").HasMaxLength(100);
        builder.Property(entity => entity.WorkspaceId).HasColumnName("workspace_id").HasMaxLength(64);
        builder.Property(entity => entity.Fingerprint).HasColumnName("fingerprint").HasMaxLength(64);
        builder.Property(entity => entity.TinnyFingerprint).HasColumnName("tinny_fingerprint").HasMaxLength(100);
        builder.Property(entity => entity.ObjectKey).HasColumnName("object_key").HasMaxLength(1000);
        builder.Property(entity => entity.SubFileType).HasColumnName("sub_file_type");
        builder.Property(entity => entity.IsOriginal).HasColumnName("is_original");
        builder.Property(entity => entity.Drone).HasColumnName("drone").HasMaxLength(32);
        builder.Property(entity => entity.Payload).HasColumnName("payload").HasMaxLength(32);
        builder.Property(entity => entity.JobId).HasColumnName("job_id").HasMaxLength(64);

        builder.Property(entity => entity.CreateTime).HasColumnName("create_time");
        builder.Property(entity => entity.UpdateTime).HasColumnName("update_time");
    }
}
