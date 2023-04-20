namespace Isaccoop.Game;

/// <summary>
/// NonShootingEnemy class that models non shooting enemy.
/// </summary>
public class NonShootingEnemy : AbstractEnemy
{
    /// <summary>
    /// NonShootingEnemy Constructor.
    /// </summary>
    public NonShootingEnemy() : base(EnemyHearts.BaseEnemyHearts, new NonShootingMovementStrategy(),
        new NonShootingHitStrategy())
    {
        //
    }
}