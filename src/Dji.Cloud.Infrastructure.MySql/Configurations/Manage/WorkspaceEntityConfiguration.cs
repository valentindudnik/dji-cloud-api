using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MySql.Configurations.Manage;

public class WorkspaceEntityConfiguration : IEntityTypeConfiguration<WorkspaceEntity>
{
    public void Configure(EntityTypeBuilder<WorkspaceEntity> builder)
    {
        builder.ToTable("manage_workspace", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.WorkspaceId).HasColumnName("workspace_id").HasMaxLength(64);
        builder.Property(entity => entity.WorkspaceName).HasColumnName("workspace_name").HasMaxLength(64);
        builder.Property(entity => entity.WorkspaceDesc).HasColumnName("workspace_desc").HasMaxLength(100);
        builder.Property(entity => entity.PlatformName).HasColumnName("platform_name").HasMaxLength(64);
        builder.Property(entity => entity.BindCode).HasColumnName("bind_code").HasMaxLength(32);
        
        builder.Property(entity => entity.CreateTime).HasColumnName("create_time");
        builder.Property(entity => entity.UpdateTime).HasColumnName("update_time");
    }
}
