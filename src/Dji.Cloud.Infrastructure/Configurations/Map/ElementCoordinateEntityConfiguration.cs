using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Map;

namespace Dji.Cloud.Infrastructure.MsSql.Configurations.Map;

public class ElementCoordinateEntityConfiguration : IEntityTypeConfiguration<ElementCoordinateEntity>
{
    public void Configure(EntityTypeBuilder<ElementCoordinateEntity> builder)
    {
        builder.ToTable("ElementCoordinates", "dbo");
        builder.HasKey(entity => entity.Id).HasName("Id");

        builder.Property(entity => entity.Id).HasColumnName("Id");
        builder.Property(entity => entity.ElementId).HasColumnName("ElementId").HasMaxLength(64);
        builder.Property(entity => entity.Longitude).HasColumnName("Longitude").HasPrecision(18, 14);
        builder.Property(entity => entity.Latitude).HasColumnName("Latitude").HasPrecision(17, 14);
        builder.Property(entity => entity.Altitude).HasColumnName("Altitude").HasPrecision(17, 14);
    }
}
