using it.unibo.isaccoop.model.common;

namespace it.unibo.isaccoop.model.boundingbox
{
    /// <summary>
    /// Implements the <see cref="BoundingBox"/> interface of a circle.
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
            this._radius = radius;
        }

        /// <summary>
        /// Get circle bounding box radius.
        /// </summary>
        /// <returns>Radius of the circle bounding box.</returns>
        public double GetRadius() => _radius

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public bool IsCollidingWithCricle(Point2D center, Point2D center1, CircleBoundingBox circleBox)
        {
            return new Vector2D(center, center1).Module() <= circleBox.GetRadius() + this._radius;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public bool IsCollidingWithRecPerimeter(Point2D center, RectBoundingBox rectangleBox)
        {
            return rectangleBox.GetHeight() - center.GetY() <= this._radius || center.GetY() <= this._radius
                || rectangleBox.GetWidth() - center.GetX() <= this._radius || center.GetX() <= this._radius;
        }
    }
}
