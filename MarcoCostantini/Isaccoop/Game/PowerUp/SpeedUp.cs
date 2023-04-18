namespace Isaccoop.Game;

/// <summary>
/// Represents the power up speed.
/// </summary>

public sealed class SpeedUp : PowerUp
{
    private const double SpeedUpStandard = 1.0;
    private const double SpeedSuperUp = 0.5;
    /// <summary>
    /// Increase the player's speed.
    /// </summary>
    /// <param name="p">reference to player. </param>
    public override void Interact(IPlayerStat p)
    {
        if(base.SuperItem)
        {
            p.Speed += SpeedSuperUp;
        } else {
            p.Speed += SpeedUpStandard;
        }
    }
}