namespace Isaccoop.Game
{
    /// <summary>
    /// Represents the generic power up and the super powerUp.
    /// </summary>
    public abstract class PowerUp : AbstractItem
    {
        private const int Price = 2;
        private const int SuperPrice = 4;

        /// <summary>
        /// Getter and Setter using Proprierties.
        /// </summary>
        public bool SuperItem { get; set; }

        /// <summary>
        /// Get powerUp price.
        /// </summary>
        /// <returns> price of powerUp </returns>
        public int GetPrice() => SuperItem ? Price : SuperPrice;
    }
}

