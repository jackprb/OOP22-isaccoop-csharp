using System.Collections.Generic;

namespace Isaccoop.Model.Common
{
    /// <summary>
    /// Struct that models the concept of direction.
    /// </summary>
    public struct Direction
    {
        private Direction(double x, double y) 
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Get the X component of this <see cref="Direction"/>.
        /// </summary>
        public double X { get; }

        /// <summary>
        /// Get the Y component of this <see cref="Direction"/>.
        /// </summary>
        public double Y { get; }

        /// <summary>
        /// Get the direction Up.
        /// </summary>
        /// <returns>The direction Up</returns>
        public static Direction Up() => new Direction(0.0, -1.0);

        /// <summary>
        /// Get the direction Down.
        /// </summary>
        /// <returns>The direction Down</returns>
        public static Direction Down() => new Direction(0.0, 1.0);

        /// <summary>
        /// Get the direction Right.
        /// </summary>
        /// <returns>The direction Right</returns>
        public static Direction Right() => new Direction(1.0, 0.0);

        /// <summary>
        /// Get the direction Left.
        /// </summary>
        /// <returns>The direction Left</returns>
        public static Direction Left() => new Direction(-1.0, 0.0);

        /// <summary>
        /// Returns a list containing all Directions.
        /// </summary>
        /// <returns>the list of all Directions</returns>
        public static IList<Direction> ToList()
        {
            List<Direction> directions = new List<Direction>();
            directions.Add(Direction.Down());
            directions.Add(Direction.Left());
            directions.Add(Direction.Right());
            directions.Add(Direction.Up());
            return directions;
        }
    }
}
