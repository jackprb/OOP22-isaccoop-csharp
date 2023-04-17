namespace Isaccoop.Game
{
    /// <summary>
    /// Interface that allows to create a <see cref="ILevel"/> dynamically.
    /// </summary>
    public interface ILevelFactory
    {
        /// <summary>
        /// Generates dynamically a <see cref="ILevel"/> made of a random number of <see cref="IRoom"/>s.
        /// The level will have at least 6 rooms and at most 30.
        /// </summary>
        ///<returns>the level created</returns>
        public ILevel CreateLevel();
    }
}
