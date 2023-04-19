namespace Isaccoop.Game
{
    /// <summary>
    /// Represents the power up coin.
    /// </summary>

    public sealed class CoinUp : PowerUp
    {
        private const int CoinUpStandard = 4;
        private const int CoinSuperUp = 8;
        /// <summary>
        /// Increase the player's money.
        /// </summary>
        /// <param name="p">reference to player. </param>
        public override void Interact(IPlayerStat p)
        {
            if (base.SuperItem)
            {
                p.Coin += CoinSuperUp;
            }
            else
            {
                p.Coin += CoinUpStandard;
            }
        }
    }
}

