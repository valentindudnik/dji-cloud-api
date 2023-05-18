using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Map;

namespace Dji.Cloud.Infrastructure.MySql.Configurations;

public class GroupEntityConfiguration : IEntityTypeConfiguration<GroupEntity>
{
    public void Configure(EntityTypeBuilder<GroupEntity> builder)
    {
        builder.ToTable("map_group", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.GroupId).HasColumnName("group_id").HasMaxLength(64);
        builder.Property(entity => entity.GroupName).HasColumnName("group_name").HasMaxLength(64);
        builder.Property(entity => entity.GroupType).HasColumnName("group_type");
        builder.Property(entity => entity.WorkspaceId).HasColumnName("workspace_id").HasMaxLength(64);
        builder.Property(entity => entity.IsDistributed).HasColumnName("is_distributed");
        builder.Property(entity => entity.IsLock).HasColumnName("is_lock");

        builder.Property(entity => entity.CreateTime).HasColumnName("create_time");
        builder.Property(entity => entity.UpdateTime).HasColumnName("update_time");
    }
}
