using Isaccoop.Game.Common;

namespace Isaccoop.Game{

    /// <summary>
    /// The class for the NonShootingEnemy.
    /// </summary>
    public class NonShootingEnemy : AbstractEnemy
    {

        /// <summary>
        /// NonShootingEnemy constructor.
        /// </summary>
        public NonShootingEnemy()
        {
        }

        /// <inheritdoc cref="IHitable" />
        public void OnHit(readonly IPlayerStat player)
        {
            if( ((NonShootingHitStrategy) base.GetHitStrategy()).CanHit() ) {
                base.OnHit(player);
            }
        }
    }
}