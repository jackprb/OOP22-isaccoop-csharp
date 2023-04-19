using Isaccoop.Game.Common;
using System;

namespace Isaccoop.Game{

    /// <summary>
    /// The class for the NonShootingEnemy.
    /// </summary>
    public class NonShootingEnemy : AbstractEnemy
    {

        /// <summary>
        /// NonShootingEnemy constructor.
        /// </summary>
        public NonShootingEnemy() : base(10.0, new NonShootingMovementStrategy(), new NonShootingHitStrategy())
        {
        
        }

        /// <inheritdoc cref="IHitable" />
        public void OnHit(IPlayerStat player)
        {
            if( ((NonShootingHitStrategy) base.GetHitStrategy()).CanHit() ) {
                base.OnHit(player);
            }
        }
    }
}