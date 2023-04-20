namespace Isaccoop.Game.Common;

/// <summary>
/// Removable interface to model objects delegates to delete elements.
/// </summary>
public interface IRemovable
{
    /// <summary>
    /// Remove a certain element.
    /// </summary>
    /// <param name="e"></param>
    void Remove(IMapElement e);
}