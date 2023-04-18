namespace Isaccoop.Game.Common;

/// <summary>
/// Interface to model elements.
/// </summary>
public interface IMapElement
{
    /// <summary>
    /// Get element coords.
    /// <returns>the coordinates of a map element</returns>
    /// </summary>
    Point2D GetCoords();

    /// <summary>
    /// Set new coords to map element.
    /// <param name="coords">new coords</param>
    /// </summary>
    void SetCoords(Point2D coords);
    
}