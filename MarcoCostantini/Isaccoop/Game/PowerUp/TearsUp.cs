namespace Isaccoop.Game;

/// <summary>
/// Represents the power up tears.
/// </summary>

public sealed class TearsUp : PowerUp
{
    private const int TearsUpStandard = -400;
    private const int TearsSuperUp = -600;
    /// <summary>
    /// Increase the player's tears.
    /// </summary>
    /// <param name="p">reference to player. </param>
    public override void Interact(IPlayerStat p)
    {
        if(base.SuperItem)
        {
            p.Tears += TearsSuperUp;
        } else {
            p.Tears += TearsUpStandard;
        }
    }
}