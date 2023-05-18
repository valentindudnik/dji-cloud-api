using Dji.Cloud.Infrastructure.Abstracts.Entities.Common;

namespace Dji.Cloud.Infrastructure.Abstracts.Entities.Map;

public class ElementCoordinateEntity : BaseEntity
{
    public string? ElementId { get; set; }
    public decimal Longitude { get; set; }
    public decimal Latitude { get; set; }
    public decimal Altitude { get; set; }
}
