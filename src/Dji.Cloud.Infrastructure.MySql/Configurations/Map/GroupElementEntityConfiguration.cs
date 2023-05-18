using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Map;

namespace Dji.Cloud.Infrastructure.MySql.Configurations.Map;

public class GroupElementEntityConfiguration : IEntityTypeConfiguration<GroupElementEntity>
{
    public void Configure(EntityTypeBuilder<GroupElementEntity> builder)
    {
        builder.ToTable("map_group_element", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.ElementId).HasColumnName("element_id").HasMaxLength(64);
        builder.Property(entity => entity.ElementName).HasColumnName("element_name").HasMaxLength(64);
        builder.Property(entity => entity.Display).HasColumnName("display");
        builder.Property(entity => entity.GroupId).HasColumnName("group_id").HasMaxLength(64);
        builder.Property(entity => entity.ElementType).HasColumnName("element_type");
        builder.Property(entity => entity.UserName).HasColumnName("username").HasMaxLength(64);
        builder.Property(entity => entity.Color).HasColumnName("color").HasMaxLength(32);
        builder.Property(entity => entity.ClampToGround).HasColumnName("clamp_to_ground");

        builder.Property(entity => entity.CreateTime).HasColumnName("create_time");
        builder.Property(entity => entity.UpdateTime).HasColumnName("update_time");
    }
}
