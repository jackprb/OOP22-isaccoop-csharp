using Isaccoop.Game.Common;

namespace Isaccoop.Game{
    /// <summary>
    /// The class for ShootingMovementStrategy.
    /// </summary>
    public class PlayerStatImpl : IMovementStrategy
    {
        private static readonly long TIME_INTERVAL = 500;
        private long _elapsedNewVector;
        private Vector2D _movementVector;

        public ShootingMovementStrategy()
        {
        }
    }
}