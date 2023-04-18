namespace Isaccoop.Game.Common;

/// <summary>
/// HitStrategy interface.
/// </summary>
public interface IHitStrategy
{
    /// <summary>
    /// Method to perform hit action according to the strategy.
    /// </summary>
    /// <param name="direction">direction in which i fire the shot</param>
    /// <param name="caller"></param>
    void Hit(Vector2D? direction, IMapElement caller);
}