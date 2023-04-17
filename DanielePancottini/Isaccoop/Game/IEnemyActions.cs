using Isaccoop.Game.Common;

namespace Isaccoop.Game;

public interface IEnemyActions
{
    public void Hit(Point2D playerPosition);
    
    public void Move(Point2D playerPosition);
}