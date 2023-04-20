using Isaccoop.Game.Common;
using System;

namespace Isaccoop.Game{
    /// <summary>
    /// The class for ShootingMovementStrategy.
    /// </summary>
    public class ShootingMovementStrategy : IMovementStrategy
    {
        private static readonly long TIME_INTERVAL = 500;
        private long _elapsedNewVector;
        private Vector2D _movementVector;

        public ShootingMovementStrategy()
        {
        }

        Point2D IMovementStrategy.Move(Point2D enemyPosition, Point2D playerPosition)
        {
            throw new NotImplementedException();
        }
    }
}