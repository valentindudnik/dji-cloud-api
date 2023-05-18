namespace Dji.Cloud.Domain.Map;

public class ResourceContent
{
    public static readonly string Type = "Feature";

    public ContentProperty? Properties { get; set; }

    public ElementType? Geometry { get; set; }
}
