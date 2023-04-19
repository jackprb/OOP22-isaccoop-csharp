namespace Isaccoop.Game
{
    /// <summary>
    /// Functional interface that manages the creation of items and enemies.
    /// </summary>
    public interface Creator<E>
    {
        /**
         * Method to create a {@link List} of <E> type objects.
         *
         * @return {@link List} of <E> type with created objects
         * */
        List<E> create();
    }
}

