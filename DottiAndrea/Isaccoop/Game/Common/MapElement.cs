using System;

namespace Isaccoop.Game.Common
{
    public class MapElement : IMapElement
{
    private Point2D coords;
    private IBoundingBox box;
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
        this.coords = new Point2D(FIXED_INITIAL_POSITION, FIXED_INITIAL_POSITION);
        this.box = new CircleBoundingBox((double) elemRadius);
    }

    public MapElement(int width, int height)
    {
        this.coords = new Point2D(0.0, 0.0);
        this.box = new RectBoundingBox(width, height);
    }

    public Point2D GetCoords()
    {
        return new Point2D(this.coords.X, this.coords.Y);
    }

    public void SetCoords(Point2D coords)
    {
        this.coords = new Point2D(coords.X, coords.Y);
    }

    public IBoundingBox GetBox()
    {
        return this.box;
    }

    public override int GetHashCode()
    {
        return coords.GetHashCode();
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
        return coords.X.CompareTo(other.coords.X) == 0
            && coords.Y.CompareTo(other.coords.Y) == 0;
    }
}
}
