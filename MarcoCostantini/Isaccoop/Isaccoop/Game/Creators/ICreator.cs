using System.Collections.Generic;

namespace Isaccoop.Game
{
    /// <summary>
    /// Functional interface that manages the creation of items and enemies.
    /// </summary>
    public interface ICreator<E>
    {
        /// <summary>
        /// Method to create a {@link List} of <E> type objects.
        /// </summary>
        List<E> Create();
    }
}

