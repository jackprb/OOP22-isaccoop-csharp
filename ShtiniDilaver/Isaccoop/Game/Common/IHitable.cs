namespace Isaccoop.Game{

    /// <summary>
    /// Genertic Hitable subject.
    /// </summary>
    /// <param name="E">Entity type to be passed to onHit method.</param>
    public interface IHitable<E>
    {

        /// <summary>
        /// Method to be called when the culpable is hit.
        /// </summary>
        /// <param name="entity">entity object in order to handle collision with another entity.</param>
        void OnHit(E entity);

    }
}
