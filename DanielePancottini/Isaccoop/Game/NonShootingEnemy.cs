using Isaccoop.Game.Common;

namespace Isaccoop.Game;

public class NonShootingEnemy : AbstractEnemy
{
    
    public NonShootingEnemy() : base(EnemyHearts.BaseEnemyHearts, new NonShootingMovementStrategy(),
        new NonShootingHitStrategy())
    {
        //
    }
}