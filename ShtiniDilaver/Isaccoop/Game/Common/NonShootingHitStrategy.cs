using Isaccoop.Game.Common;

namespace Isaccoop.Game;

public class NonShootingHitStrategy : IHitStrategy
{
    private bool CanHit;

    public NonShootingHitStrategy() 
    {
        CanHit = false;
    }

    public void Hit(Vector2D? direction, IMapElement caller)
    {
        throw new NotImplementedException();
    }

    public bool CanHit() 
    {
        return CanHit;
    }
}