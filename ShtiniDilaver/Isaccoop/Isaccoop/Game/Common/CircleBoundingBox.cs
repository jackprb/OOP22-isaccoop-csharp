
namespace Isaccoop.Game.Common
{
    /// <summary>
    /// Implements the <see cref="IBoundingBox"/> interface of a circle.
    /// </summary>
    public class CircleBoundingBox : IBoundingBox
    {
        private readonly double _radius;

        /// <summary>
        /// Constructor of the circle bounding box.
        /// </summary>
        /// <param name="radius"></param>
        public CircleBoundingBox(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// Get circle bounding box radius.
        /// </summary>
        /// <returns>Radius of the circle bounding box.</returns>
        public double GetRadius() => _radius;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public bool IsCollidingWithCricle(Point2D center, Point2D center1, CircleBoundingBox circleBox)
        {
            return new Vector2D(center, center1).Module() <= circleBox.GetRadius() + _radius;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public bool IsCollidingWithRecPerimeter(Point2D center, RectBoundingBox rectangleBox)
        {
            return rectangleBox.GetHeight() - center.Y <= _radius || center.Y <= _radius
                || rectangleBox.GetWidth() - center.X <= _radius || center.X <= _radius;
        }
    }
}