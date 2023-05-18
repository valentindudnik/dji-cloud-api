namespace Dji.Cloud.Domain.Map;

public abstract class ElementType
{
    public ElementType(string type)
    {
        Type = type;
    }

    public string? Type { get; set; }

    /// <summary>
    /// Convert coordinate data into objects and then add them to the collection.
    /// </summary>
    /// <returns></returns>
    public abstract Task<IEnumerable<ElementCoordinate>> ConvertToAsync();

    /// <summary>
    /// Converts coordinates in a collection of objects to a specific type.
    /// </summary>
    /// <param name="coordinates">coordinates</param>
    /// <returns></returns>
    public abstract Task AdapterCoordinateTypeAsync(IEnumerable<ElementCoordinate> coordinates);
}
