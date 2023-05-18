using Dji.Cloud.Domain.Map;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Map;

public interface IElementCoordinateService
{
    /// <summary>
    /// Query all the coordinates of the element according to its id.
    /// </summary>
    /// <param name="elementId">element id</param>
    /// <returns></returns>
    Task<IEnumerable<ElementCoordinate>> GetCoordinateByElementIdAsync(string elementId);

    /// <summary>
    /// Save all the coordinate data of this element.
    /// </summary>
    /// <param name="coordinates">coordinates</param>
    /// <param name="elementId">element id</param>
    /// <returns></returns>
    Task<bool> SaveCoordinateAsync(IEnumerable<ElementCoordinate> coordinates, string elementId);

    /// <summary>
    /// Delete all the coordinates of the element according to its id.
    /// </summary>
    /// <param name="elementId">element id</param>
    /// <returns></returns>
    Task<bool> DeleteCoordinateByElementIdAsync(string elementId);
}
