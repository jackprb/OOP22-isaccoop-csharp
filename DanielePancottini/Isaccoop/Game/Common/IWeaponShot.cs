namespace Isaccoop.Game.Common;

/// <summary>
/// WeaponShot interface that models the weapon shot concept.
/// </summary>
public interface IWeaponShot : IMapElement
{
    /// <summary>
    /// Method to update the weapon shot state.
    /// </summary>
    void TickShot();
}