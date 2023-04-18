namespace Isaccoop.Game;

/// <summary>
/// Represents the power up health.
/// </summary>

public sealed class HealthUp : PowerUp
{
    private const int HealthUpStandard = 1;
    private const int HealthSuperUp = 2;
    /// <summary>
    /// Increase the player's health.
    /// </summary>
    /// <param name="p">reference to player. </param>
    public override void Interact(IPlayerStat p)
    {
        if(base.SuperItem)
        {
            p.MaxHeart += HealthSuperUp;
        } else {
            p.MaxHeart += HealthUpStandard;
        }
    }
}