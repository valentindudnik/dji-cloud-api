using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Dji.Cloud.Infrastructure.Abstracts.Entities.Map;

namespace Dji.Cloud.Infrastructure.MySql.Configurations.Map;

public class ElementCoordinateEntityConfiguration : IEntityTypeConfiguration<ElementCoordinateEntity>
{
    public void Configure(EntityTypeBuilder<ElementCoordinateEntity> builder)
    {
        builder.ToTable("map_element_coordinate", "dbo");
        builder.HasKey(entity => entity.Id).HasName("id");

        builder.Property(entity => entity.Id).HasColumnName("id");
        builder.Property(entity => entity.ElementId).HasColumnName("element_id").HasMaxLength(64);
        builder.Property(entity => entity.Longitude).HasColumnName("longitude").HasPrecision(18, 14);
        builder.Property(entity => entity.Latitude).HasColumnName("latitude").HasPrecision(17, 14);
        builder.Property(entity => entity.Altitude).HasColumnName("altitude").HasPrecision(17, 14);
    }
}
