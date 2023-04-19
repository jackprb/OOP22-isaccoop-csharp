namespace Isaccoop.Game
{
    /// <summary>
    /// Abstract class that models items.
    /// </summary>
    public abstract class AbstractItem : IItem
    {
        /// <summary>
        /// Method that applies the item's effect to the player.
        /// </summary>
        public abstract void Interact(IPlayerStat p);
    }
}

