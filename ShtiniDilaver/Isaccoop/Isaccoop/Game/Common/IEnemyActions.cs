using Isaccoop.Game.Common;

namespace Isaccoop.Game
{

    /// <summary>
    ///  EnemyActions interface to model enemy action like hit and move.
    /// </summary>
    public interface IEnemyActions
    {
        /// <summary>
        /// Perform hit action of a certain enemy.
        /// <param name="playerPosition">current player position</param>
        /// </summary>
        public void Hit(Point2D playerPosition);

        /// <summary>
        /// Perform move action of a certain enemy.
        /// <param name="playerPosition">current player position</param>
        /// </summary>
        public void Move(Point2D playerPosition);
    }
}