using System;

namespace Isaccoop.Game.Common
{
    public class MapElement : IMapElement
    {
        private Point2D _coords;
        private readonly IBoundingBox _box;
        private const double FIXED_INITIAL_POSITION = 10.0;

        public enum ElementsRadius
        {
            DEFAULT = 0,
            ENEMY = 8,
            ITEM = 5,
            PLAYER = 8,
            BOSS = 20,
            BULLET = 3
        }

        public MapElement(ElementsRadius elemRadius)
        {
            _coords = new Point2D(FIXED_INITIAL_POSITION, FIXED_INITIAL_POSITION);
            _box = new CircleBoundingBox((double) elemRadius);
        }

        public MapElement(int width, int height)
        {
            _coords = new Point2D(0.0, 0.0);
            _box = new RectBoundingBox(width, height);
        }

        public Point2D GetCoords()
        {
            return new Point2D(_coords.X, _coords.Y);
        }

        public void SetCoords(Point2D coords)
        {
            _coords = new Point2D(coords.X, coords.Y);
        }

        public IBoundingBox GetBox()
        {
            return _box;
        }

        public override int GetHashCode()
        {
            return _coords.GetHashCode();
        }

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
