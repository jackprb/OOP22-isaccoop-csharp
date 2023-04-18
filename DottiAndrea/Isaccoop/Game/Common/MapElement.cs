using System;

namespace Isaccoop.Game.Common
{
    /// <summary>
    /// Class that implements IMapElement interface.
    /// </summary>
    public class MapElement : IMapElement
    {
        private Point2D _coords;
        private readonly IBoundingBox _box;
        private const double FIXED_INITIAL_POSITION = 10.0;

        /// <summary>
        /// Enum for elements radius.
        /// </summary>
        public enum ElementsRadius
        {
            DEFAULT = 0,
            ENEMY = 8,
            ITEM = 5,
            PLAYER = 8,
            BOSS = 20,
            BULLET = 3
        }

        /// <summary>
        /// Class that implements IMapElement interface
        /// <param name="elemRadius"> of circle boundingBox</param>
        /// </summary>
        public MapElement(ElementsRadius elemRadius)
        {
            _coords = new Point2D(FIXED_INITIAL_POSITION, FIXED_INITIAL_POSITION);
            _box = new CircleBoundingBox((double) elemRadius);
        }

        /// <summary>
        /// Class that implements IMapElement interface
        /// <param name="width"> of the rectangle boundingBox</param>
        /// <param name="height"> of the rectangle boundingBox</param>
        /// </summary>
        public MapElement(int width, int height)
        {
            _coords = new Point2D(0.0, 0.0);
            _box = new RectBoundingBox(width, height);
        }

        /// <returns> The current MapElement position</returns>
        public Point2D GetCoords()
        {
            return new Point2D(_coords.X, _coords.Y);
        }

        /// <summary>
        /// Set the new Coords to the mapElement.
        /// </summary>
        public void SetCoords(Point2D coords)
        {
            _coords = new Point2D(coords.X, coords.Y);
        }

        /// <returns> The boundingBox of the mapElement</returns>
        public IBoundingBox GetBox()
        {
            return _box;
        }

        /// <returns> HashCode of the Coords</returns>
        public override int GetHashCode()
        {
            return _coords.GetHashCode();
        }

        /// <returns> True if two obj are equals</returns>
        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (GetType() != obj.GetType())
            {
                return false;
            }
            MapElement other = (MapElement)obj;
            return _coords.X.CompareTo(other._coords.X) == 0
                && _coords.Y.CompareTo(other._coords.Y) == 0;
        }
    }
}
