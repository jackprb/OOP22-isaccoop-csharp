using Isaccoop.Game.Common;
using System;

namespace Isaccoop.Game{

    /// <summary>
    /// Interface to manage the player movement.
    /// </summary>
    public interface IPlayerMovement
    {

        /// <summary>
        /// Update the player position.
        /// </summary>
        /// <param name="direction">The direction where player is moving.</param>
        void Update(Direction direction);

        /// <summary>
        /// Get the next position in preview.
        /// </summary>
        /// <param name="direction">The direction in which the player wants to move.</param>
        /// <returns>The future position of the player in the direction "direction".</returns>
        Point2D GetMovePreview(Direction direction);

    }

}