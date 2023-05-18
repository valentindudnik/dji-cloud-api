using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MySql.Configurations.Manage;

public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable("manage_user", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.UserId).HasColumnName("user_id").HasMaxLength(64);
        builder.Property(entity => entity.UserName).HasColumnName("username").HasMaxLength(32);
        builder.Property(entity => entity.Password).HasColumnName("password").HasMaxLength(32);
        builder.Property(entity => entity.WorkspaceId).HasColumnName("workspace_id").HasMaxLength(64);
        builder.Property(entity => entity.UserType).HasColumnName("user_type");
        builder.Property(entity => entity.MqttUserName).HasColumnName("mqtt_username").HasMaxLength(32);
        builder.Property(entity => entity.MqttPassword).HasColumnName("mqtt_password").HasMaxLength(32);

        builder.Property(entity => entity.CreateTime).HasColumnName("create_time");
        builder.Property(entity => entity.UpdateTime).HasColumnName("update_time");
    }
}
