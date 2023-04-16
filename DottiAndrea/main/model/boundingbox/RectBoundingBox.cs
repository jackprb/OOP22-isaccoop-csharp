using it.unibo.isaccoop.model.common;

namespace it.unibo.isaccoop.model.boundingbox
{
    /// <summary>
    /// Implements the <see cref="BoundingBox"/> interface of a rectangle.
    /// </summary>
    public class RectBoundingBox : IBoundingBox
    {
        private readonly int _width;
        private readonly int _height;

        /// <summary>
        /// RectBoundingBox Constructor.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public RectBoundingBox(int width, int height)
        {
            this._width = width;
            this._height = height;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public bool isCollidingWithCricle(Point2D center, Point2D center1, CircleBoundingBox circleBox) => false;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public bool isCollidingWithRecPerimeter(Point2D center, RectBoundingBox rectangleBox) => false;

        /// <summary>
        /// Get rect bounding box width.
        /// </summary>
        /// <returns>the rectangle width</returns>
        public int getWidth() => this._width;

        /// <summary>
        /// Get rect bounding box height.
        /// </summary>
        /// <returns>the rectangle height</returns>
        public int getHeight() => this._height;
    }
}
