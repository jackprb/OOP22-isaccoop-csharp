namespace Isaccoop.Game{

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

        /// <summary>
        /// Create an enum to set initial stats of the player.
        /// </summary>
        private enum PlayerValue : int
        {
            HEART = 3,
            COIN = 0,
            MAX_HEART = 3,
            SPEED = 1,
            TEARS = 1000,
            DAMAGE = 1
        }

        /// <summary>
        /// Player constructor.
        /// </summary>
        public PlayerStatImpl()
        {
            this._heart = (int)PlayerValue.HEART;
            this._maxHeart = (int)PlayerValue.MAX_HEART;
            this._coin = (int)PlayerValue.COIN;
            this._speed = (int)PlayerValue.SPEED;
            this._damage = (int)PlayerValue.DAMAGE;
            this._tears = (int)PlayerValue.TEARS;

        }

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