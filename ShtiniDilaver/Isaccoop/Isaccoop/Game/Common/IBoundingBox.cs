using System.Collections.Generic;

namespace Isaccoop.Game.Common
{
    /// <summary>
    /// Interface that models the bounding box.
    /// </summary>
    public interface IBoundingBox
    {
        /// <summary>
        /// Check for collisions of two bounding box.
        /// </summary>
        /// <param name="center"> of first bounding box</param>
        /// <param name="center1"> of the second bounding box</param>
        /// <param name="circleBox"> of the second bounding box</param>
        /// <returns> true if a collision occurs</returns>
        bool IsCollidingWithCricle(Point2D center, Point2D center1, CircleBoundingBox circleBox);

        /// <summary>
        /// Check for collisions of a bounding box with the perimeter of a rectangle bounding box.
        /// (We suppose that the first bounding box is inside the second one).
        /// </summary>
        /// <param name="center"> of first bounding box</param>
        /// <param name="rectangleBox"></param>
        /// <returns> true if a collision occurs</returns>
        bool IsCollidingWithRecPerimeter(Point2D center, RectBoundingBox rectangleBox);
    }
}