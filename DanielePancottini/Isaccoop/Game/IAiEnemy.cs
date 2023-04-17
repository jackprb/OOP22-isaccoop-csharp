using Isaccoop.Game.Common;

namespace Isaccoop.Game;

/// <summary>
/// AIEnemy interface which represents the AI for enemies.
/// </summary>
public interface IAiEnemy
{
    /// <summary>
    /// Method to perform enemies actions (move and hit) into the room linked to AI implementation.
    /// <param name="player">player in game in order to handle enemy actions</param>
    /// </summary>
    public void UpdateEnemies(IMapElement player);

    /// <summary>
    /// Get controlled enemies list of this AiEnemy
    /// <returns>controlled enemies list</returns>
    /// </summary>
    public List<IEnemy> GetControlledEnemies();
}