using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations.Manage;

public class WorkspaceEntityConfiguration : IEntityTypeConfiguration<WorkspaceEntity>
{
    public void Configure(EntityTypeBuilder<WorkspaceEntity> builder)
    {
        builder.ToTable("Workspaces", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.WorkspaceId).HasColumnName("WorkspaceId").HasMaxLength(64);
        builder.Property(entity => entity.WorkspaceName).HasColumnName("WorkspaceName").HasMaxLength(64);
        builder.Property(entity => entity.WorkspaceDesc).HasColumnName("WorkspaceDesc").HasMaxLength(100);
        builder.Property(entity => entity.PlatformName).HasColumnName("PlatformName").HasMaxLength(64);
        builder.Property(entity => entity.BindCode).HasColumnName("BindCode").HasMaxLength(32);
        
        builder.Property(entity => entity.CreateTime).HasColumnName("CreateTime");
        builder.Property(entity => entity.UpdateTime).HasColumnName("UpdateTime");
    }
}
