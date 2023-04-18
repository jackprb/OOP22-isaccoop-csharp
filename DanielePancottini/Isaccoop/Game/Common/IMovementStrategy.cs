namespace Isaccoop.Game.Common;

/// <summary>
/// MovementStrategy interface.
/// </summary>
public interface IMovementStrategy
{
    /// <summary>
    /// Get new position by movement strategy
    /// </summary>
    /// <param name="enemyPosition">position of the enemy</param>
    /// <param name="playerPosition">position of the player</param>
    /// <returns>new position to move</returns>
    Point2D Move(Point2D enemyPosition, Point2D playerPosition);
}