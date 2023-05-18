using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Wayline;

namespace Dji.Cloud.Infrastructure.MySql.Configurations.Wayline;

public class WaylineFileEntityConfiguration : IEntityTypeConfiguration<WaylineFileEntity>
{
    public void Configure(EntityTypeBuilder<WaylineFileEntity> builder)
    {
        builder.ToTable("wayline_file", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.WaylineId).HasColumnName("wayline_id").HasMaxLength(64);
        builder.Property(entity => entity.Name).HasColumnName("name").HasMaxLength(64);
        builder.Property(entity => entity.DroneModelKey).HasColumnName("drone_model_key").HasMaxLength(32);
        builder.Property(entity => entity.PayloadModelKeys).HasColumnName("payload_model_keys").HasMaxLength(200);
        builder.Property(entity => entity.WorkspaceId).HasColumnName("workspace_id").HasMaxLength(64);
        builder.Property(entity => entity.Sign).HasColumnName("sign").HasMaxLength(64);
        builder.Property(entity => entity.ObjectKey).HasColumnName("object_key").HasMaxLength(200);
        builder.Property(entity => entity.Favorited).HasColumnName("favorited");
        builder.Property(entity => entity.TemplateTypes).HasColumnName("template_types").HasMaxLength(32);
        builder.Property(entity => entity.UserName).HasColumnName("user_name").HasMaxLength(64);
        
        builder.Property(entity => entity.CreateTime).HasColumnName("create_time");
        builder.Property(entity => entity.UpdateTime).HasColumnName("update_time");
    }
}
