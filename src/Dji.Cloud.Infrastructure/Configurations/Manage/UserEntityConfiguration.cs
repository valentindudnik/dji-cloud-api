using Dji.Cloud.Infrastructure.Abstracts.Entities.Manage;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations.Manage;

public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable("Users", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.UserId).HasColumnName("UserId").HasMaxLength(64);
        builder.Property(entity => entity.UserName).HasColumnName("UserName").HasMaxLength(32);
        builder.Property(entity => entity.Password).HasColumnName("Password").HasMaxLength(32);
        builder.Property(entity => entity.WorkspaceId).HasColumnName("WorkspaceId").HasMaxLength(64);
        builder.Property(entity => entity.UserType).HasColumnName("UserType");
        builder.Property(entity => entity.MqttUserName).HasColumnName("MqttUserName").HasMaxLength(32);
        builder.Property(entity => entity.MqttPassword).HasColumnName("MqttPassword").HasMaxLength(32);

        builder.Property(entity => entity.CreateTime).HasColumnName("CreateTime");
        builder.Property(entity => entity.UpdateTime).HasColumnName("UpdateTime");
    }
}
