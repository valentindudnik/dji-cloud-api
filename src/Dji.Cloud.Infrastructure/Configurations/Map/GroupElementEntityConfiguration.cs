using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Map;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations.Map;

public class GroupElementEntityConfiguration : IEntityTypeConfiguration<GroupElementEntity>
{
    public void Configure(EntityTypeBuilder<GroupElementEntity> builder)
    {
        builder.ToTable("GroupElements", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.ElementId).HasColumnName("ElementId").HasMaxLength(64);
        builder.Property(entity => entity.ElementName).HasColumnName("ElementName").HasMaxLength(64);
        builder.Property(entity => entity.Display).HasColumnName("Display");
        builder.Property(entity => entity.GroupId).HasColumnName("GroupId").HasMaxLength(64);
        builder.Property(entity => entity.ElementType).HasColumnName("ElementType");
        builder.Property(entity => entity.UserName).HasColumnName("UserName").HasMaxLength(64);
        builder.Property(entity => entity.Color).HasColumnName("Color").HasMaxLength(32);
        builder.Property(entity => entity.ClampToGround).HasColumnName("ClampToGround");

        builder.Property(entity => entity.CreateTime).HasColumnName("CreateTime");
        builder.Property(entity => entity.UpdateTime).HasColumnName("UpdateTime");
    }
}
