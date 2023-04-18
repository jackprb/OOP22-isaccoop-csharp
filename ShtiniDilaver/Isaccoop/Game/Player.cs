namespace Isaccoop.Game{

    /// <summary>
    /// The class for the player.
    /// </summary>
    public class Player : PlayerMovementImpl
    {
        /// <summary>
        /// Player constructor.
        /// </summary>
        public Player()
        {
            base();
        }

        /// <summary>
        /// Move the player along passed direction.
        /// </summary>
        /// <param name="direction">The direction where player is moving.</param>
        void move(readonly Direction direction)
        {
            base.Update(direction);
        }

        /// <inheritdoc cref="IHitable" />
       public void onHit(readonly Enemy enemy)
       {
            enemy.SetHearts(base.Damage());
       } 

    }
}