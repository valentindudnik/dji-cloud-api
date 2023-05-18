using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Map;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations;

public class GroupEntityConfiguration : IEntityTypeConfiguration<GroupEntity>
{
    public void Configure(EntityTypeBuilder<GroupEntity> builder)
    {
        builder.ToTable("Groups", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.GroupId).HasColumnName("GroupId").HasMaxLength(64);
        builder.Property(entity => entity.GroupName).HasColumnName("GroupName").HasMaxLength(64);
        builder.Property(entity => entity.GroupType).HasColumnName("GroupType");
        builder.Property(entity => entity.WorkspaceId).HasColumnName("WorkspaceId").HasMaxLength(64);
        builder.Property(entity => entity.IsDistributed).HasColumnName("IsDistributed");
        builder.Property(entity => entity.IsLock).HasColumnName("IsLock");

        builder.Property(entity => entity.CreateTime).HasColumnName("CreateTime");
        builder.Property(entity => entity.UpdateTime).HasColumnName("UpdateTime");
    }
}
