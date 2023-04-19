namespace Isaccoop.Game;

/// <summary>
/// Interface that models items.
/// </summary>
public interface IItem
{
    /// <summary>
    /// Method for interacting with player stats.
    /// </summary>
    /// <param name="p">reference to player. </param>
    void Interact(IPlayerStat p);
}