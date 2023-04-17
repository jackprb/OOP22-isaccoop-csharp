namespace Isaccoop.Game;

/// <summary>
/// Represents a heart in the game.
/// </summary>

public sealed class Heart : AbstractItem
{
    private const int HeartUp = 1;
    /// <summary>
    /// Method for interacting with player heart.
    /// </summary>
    /// <param name="p">reference to player. </param>
    public override void Interact(IPlayerStat p) => p.Heart += HeartUp;
}