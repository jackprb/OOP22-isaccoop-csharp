namespace Isaccoop.Game
{
    /// <summary>
    /// Represents the power up damage.
    /// </summary>

    public sealed class DamageUp : PowerUp
    {
        private const double DamageUpStandard = 1.0;
        private const double DamageSuperUp = 2.0;
        /// <summary>
        /// Increase the player's damage.
        /// </summary>
        /// <param name="p">reference to player. </param>
        public override void Interact(IPlayerStat p)
        {
            if (base.SuperItem)
            {
                p.Damage += DamageSuperUp;
            }
            else
            {
                p.Damage += DamageUpStandard;
            }
        }
    }
}
