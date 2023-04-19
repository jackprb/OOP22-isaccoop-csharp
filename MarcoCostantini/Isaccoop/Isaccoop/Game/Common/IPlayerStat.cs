namespace Isaccoop.Game
{

    /// <summary>
    /// Interface to manage player statistics.
    /// </summary>
    public interface IPlayerStat
    {

        /// <summary>
        /// Get if the player is dead or not.
        /// </summary>
        ///<returns>If the player is dead.</returns>
        bool IsDead { get; }

        /// <summary>
        /// Get and set the player hearts.
        /// </summary>
        ///<returns>The hearts of the player.</returns>
        int Heart { get; set; }

        /// <summary>
        /// Get and set the max hearts of the player.
        /// </summary>
        ///<returns>The max hearts of the player.</returns>
        int MaxHeart { get; set; }

        /// <summary>
        /// Get and set the player coin.
        /// </summary>
        ///<returns>The coin of the player.</returns>
        int Coin { get; set; }

        /// <summary>
        /// Get and set the player speed.
        /// </summary>
        ///<returns>The speed of the player.</returns>
        double Speed { get; set; }

        /// <summary>
        /// Get and set the player damage.
        /// </summary>
        ///<returns>The damage of the player.</returns>
        double Damage { get; set; }

        /// <summary>
        /// Get and set the player tears.
        /// </summary>
        ///<returns>The tears of the player.</returns>
        double Tears { get; set; }

    }
}