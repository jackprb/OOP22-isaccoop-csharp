using System;
using Isaccoop.Game;
using Isaccoop.Game.Common;
using System.Collections.Generic;

namespace Isaccoop.Game{

    /// <summary>
    /// The class for the player.
    /// </summary>
    public class Player : PlayerMovementImpl, IHitable<IEnemy>
    {
        /// <summary>
        /// Move the player along passed direction.
        /// </summary>
        /// <param name="direction">The direction where player is moving.</param>
        void Move(Direction direction)
        {
            base.Update(direction);
        }

        /// <inheritdoc cref="IHitable" />
       public void OnHit(IEnemy enemy)
       {
            enemy.SetHearts(base.Damage);
       }

        internal void Update(Func<Direction> up)
        {
            throw new NotImplementedException();
        }
    }
}