using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Wayline;

namespace Dji.Cloud.Infrastructure.MySql.Configurations.Wayline;

public class WaylineJobEntityConfiguration : IEntityTypeConfiguration<WaylineJobEntity>
{
    public void Configure(EntityTypeBuilder<WaylineJobEntity> builder)
    {
        builder.ToTable("wayline_job", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.JobId).HasColumnName("job_id").HasMaxLength(45);
        builder.Property(entity => entity.Name).HasColumnName("name").HasMaxLength(64);
        builder.Property(entity => entity.FileId).HasColumnName("file_id").HasMaxLength(45);
        builder.Property(entity => entity.DockSerialNumber).HasColumnName("dock_sn").HasMaxLength(45);
        builder.Property(entity => entity.WorkspaceId).HasColumnName("workspace_id").HasMaxLength(45);
        builder.Property(entity => entity.TaskType).HasColumnName("task_type");
        builder.Property(entity => entity.WaylineType).HasColumnName("wayline_type");
        builder.Property(entity => entity.ExecuteTime).HasColumnName("execute_time");
        builder.Property(entity => entity.CompletedTime).HasColumnName("completed_time");
        builder.Property(entity => entity.UserName).HasColumnName("username").HasMaxLength(64);
        builder.Property(entity => entity.BeginTime).HasColumnName("begin_time");
        builder.Property(entity => entity.EndTime).HasColumnName("end_time");
        builder.Property(entity => entity.ErrorCode).HasColumnName("error_code");
        builder.Property(entity => entity.Status).HasColumnName("status");
        builder.Property(entity => entity.RthAltitude).HasColumnName("rth_altitude");
        builder.Property(entity => entity.OutOfControlAction).HasColumnName("out_of_control");
        builder.Property(entity => entity.MediaCount).HasColumnName("media_count");
        builder.Property(entity => entity.ParentId).HasColumnName("parent_id").HasMaxLength(45);

        builder.Property(entity => entity.CreateTime).HasColumnName("create_time");
        builder.Property(entity => entity.UpdateTime).HasColumnName("update_time");
    }
}
