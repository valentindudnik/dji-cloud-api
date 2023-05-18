using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Wayline;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations.Wayline;

public class WaylineFileEntityConfiguration : IEntityTypeConfiguration<WaylineFileEntity>
{
    public void Configure(EntityTypeBuilder<WaylineFileEntity> builder)
    {
        builder.ToTable("WaylineFiles", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.WaylineId).HasColumnName("WaylineId").HasMaxLength(64);
        builder.Property(entity => entity.Name).HasColumnName("Name").HasMaxLength(64);
        builder.Property(entity => entity.DroneModelKey).HasColumnName("DroneModelKey").HasMaxLength(32);
        builder.Property(entity => entity.PayloadModelKeys).HasColumnName("PayloadModelKeys").HasMaxLength(200);
        builder.Property(entity => entity.WorkspaceId).HasColumnName("WorkspaceId").HasMaxLength(64);
        builder.Property(entity => entity.Sign).HasColumnName("Sign").HasMaxLength(64);
        builder.Property(entity => entity.ObjectKey).HasColumnName("ObjectKey").HasMaxLength(200);
        builder.Property(entity => entity.Favorited).HasColumnName("Favorited");
        builder.Property(entity => entity.TemplateTypes).HasColumnName("TemplateTypes").HasMaxLength(32);
        builder.Property(entity => entity.UserName).HasColumnName("UserName").HasMaxLength(64);
        
        builder.Property(entity => entity.CreateTime).HasColumnName("CreateTime");
        builder.Property(entity => entity.UpdateTime).HasColumnName("UpdateTime");
    }
}
