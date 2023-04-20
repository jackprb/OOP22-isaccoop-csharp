namespace Isaccoop.Game
{

    /// <summary>
    /// The class for player stats.
    /// </summary>
    public class PlayerStatImpl : IPlayerStat
    {
        private int _heart;
        private int _maxHeart;
        private int _coin;
        private double _speed;
        private double _damage;
        private double _tears;

        /// <inheritdoc cref="IPlayerStat" />
        public bool IsDead => this._heart <= 0;

        /// <inheritdoc cref="IPlayerStat" />
        public int Heart { get => this._heart; set => _heart = value; }

        /// <inheritdoc cref="IPlayerStat" />
        public int MaxHeart { get => this._maxHeart; set => _maxHeart = value; }

        /// <inheritdoc cref="IPlayerStat" />
        public int Coin { get => this._coin; set => _coin = value; }

        /// <inheritdoc cref="IPlayerStat" />
        public double Speed { get => this._speed; set => _speed = value; }

        /// <inheritdoc cref="IPlayerStat" />
        public double Damage { get => this._damage; set => _damage = value; }

        /// <inheritdoc cref="IPlayerStat" />
        public double Tears { get => this._tears; set => _tears = value < 100.0 ? 100.0 : value; }

        /// <summary>
        /// Check if the player died with the last shot.
        /// </summary>
        ///<returns>If the player has exhausted the hearts.</returns>
        public bool IsHitted()
        {
            if (Heart >= 1)
            {
                Heart -= 1;
            }
            return this.IsDead;
        }
    }

}