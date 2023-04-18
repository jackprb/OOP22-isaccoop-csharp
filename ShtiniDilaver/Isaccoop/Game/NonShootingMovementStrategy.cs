using Isaccoop.Game.Common;

namespace Isaccoop.Game{

    /// <summary>
    /// The class for NonShootingMovementStrategy.
    /// </summary>
    public class NonShootingMovementStrategy : IMovementStrategy
    {

        /// <summary>
        /// Move the enemy along passed player direction.
        /// </summary>
        /// <param name="enemyPosition">The position of the enemy.</param>
        /// <param name="playerPosition">The position of the player.</param>
        public Point2D Move(Point2D enemyPosition, Point2D playerPosition)
        {
            Vector2D movementVector = playerPosition.Sub(enemyPosition).GetNormalized().Mul(NonShootingEnemy.Speed());
            return enemyPosition.Sum(movementVector);
        }
    }
}