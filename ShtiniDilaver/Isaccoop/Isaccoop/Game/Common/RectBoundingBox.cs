using Isaccoop.Game.Common;

namespace Isaccoop.Game
{
    /// <summary>
    /// Implements the <see cref="IBoundingBox"/> interface of a rectangle.
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
        public bool IsCollidingWithCricle(Point2D center, Point2D center1, CircleBoundingBox circleBox)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public bool IsCollidingWithRecPerimeter(Point2D center, RectBoundingBox rectangleBox)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Get rect bounding box width.
        /// </summary>
        /// <returns>the rectangle width</returns>
        public int GetWidth() => this._width;

        /// <summary>
        /// Get rect bounding box height.
        /// </summary>
        /// <returns>the rectangle height</returns>
        public int GetHeight() => this._height;
    }
}