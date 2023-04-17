namespace Isaccoop.Game.Common;

public interface IMapElement
{
    /// <summary>
    /// Get element coords.
    /// <returns>the coordinates of a map element</returns>
    /// </summary>
    public Point2D GetCoords();

    /// <summary>
    /// Set new coords to map element.
    /// <param name="coords">new coords</param>
    /// </summary>
    public void SetCoords(Point2D coords);
    
}