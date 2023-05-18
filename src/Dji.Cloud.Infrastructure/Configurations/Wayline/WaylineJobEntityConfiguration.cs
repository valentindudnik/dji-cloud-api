using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Wayline;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations.Wayline;

public class WaylineJobEntityConfiguration : IEntityTypeConfiguration<WaylineJobEntity>
{
    public void Configure(EntityTypeBuilder<WaylineJobEntity> builder)
    {
        builder.ToTable("WaylineJobs", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.JobId).HasColumnName("JobId").HasMaxLength(45);
        builder.Property(entity => entity.Name).HasColumnName("Name").HasMaxLength(64);
        builder.Property(entity => entity.FileId).HasColumnName("FileId").HasMaxLength(45);
        builder.Property(entity => entity.DockSerialNumber).HasColumnName("DockSerialNumber").HasMaxLength(45);
        builder.Property(entity => entity.WorkspaceId).HasColumnName("WorkspaceId").HasMaxLength(45);
        builder.Property(entity => entity.TaskType).HasColumnName("TaskType");
        builder.Property(entity => entity.WaylineType).HasColumnName("WaylineType");
        builder.Property(entity => entity.ExecuteTime).HasColumnName("ExecuteTime");
        builder.Property(entity => entity.CompletedTime).HasColumnName("CompletedTime");
        builder.Property(entity => entity.UserName).HasColumnName("UserName").HasMaxLength(64);
        builder.Property(entity => entity.BeginTime).HasColumnName("BeginTime");
        builder.Property(entity => entity.EndTime).HasColumnName("EndTime");
        builder.Property(entity => entity.ErrorCode).HasColumnName("ErrorCode");
        builder.Property(entity => entity.Status).HasColumnName("Status");
        builder.Property(entity => entity.RthAltitude).HasColumnName("RthAltitude");
        builder.Property(entity => entity.OutOfControlAction).HasColumnName("OutOfControlAction");
        builder.Property(entity => entity.MediaCount).HasColumnName("MediaCount");
        builder.Property(entity => entity.ParentId).HasColumnName("ParentId").HasMaxLength(45);

        builder.Property(entity => entity.CreateTime).HasColumnName("CreateTime");
        builder.Property(entity => entity.UpdateTime).HasColumnName("UpdateTime");
    }
}
