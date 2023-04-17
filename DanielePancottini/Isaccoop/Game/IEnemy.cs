using Isaccoop.Game.Common;

namespace Isaccoop.Game;

/// <summary>
/// Enemy interface to model enemy concept.
/// </summary>
public interface IEnemy : IEnemyActions, IMapElement
{
    
    /// <summary>
    /// Check if the enemy is dead.
    /// </summary>
    /// <returns>boolean check result</returns>
    public bool IsDead();

    /// <summary>
    /// Set enemy hearts.
    /// </summary>
    /// <param name="damage">player damage to compute new enemy hearts value</param>
    public void SetHearts(double damage);

    /// <summary>
    /// Get enemy hearts.
    /// </summary>
    /// <returns>hearts of the enemy</returns>
    double GetHearts();

    /// <summary>
    /// Get enemy weapon shots if available.
    /// </summary>
    /// <returns>enemy weapon shots as a list, empty list if shots not available</returns>
    List<IWeaponShot>? GetWeaponShots();

    /// <summary>
    /// Get enemy hit strategy.
    /// </summary>
    /// <returns>hit strategy</returns>
    IHitStrategy GetHitStrategy();
}