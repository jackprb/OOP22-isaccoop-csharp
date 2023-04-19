namespace Isaccoop.Game
{
    /// <summary>
    /// Represents a coin in the game.
    /// </summary>

    public sealed class Coin : AbstractItem
    {
        private const int CoinUp = 1;
        /// <summary>
        /// Method for interacting with player money.
        /// </summary>
        /// <param name="p">reference to player. </param>
        public override void Interact(IPlayerStat p) => p.Coin += CoinUp;
    }
}

