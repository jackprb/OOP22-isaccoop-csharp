using Isaccoop.Game.Common;

namespace Isaccoop.Game;

/// <summary>
/// AbstractEnemy abstract class that extends AbstractMapElement and implements Enemy,
/// it is used as a common container for enemies state and behavior.
/// </summary>
public abstract class AbstractEnemy : IEnemy
{
    
    private const double FixedInitialPosition = 10.0;

    private Point2D _coords;
    private double _hearts;
    private readonly IMovementStrategy _movementStrategy;
    private readonly IHitStrategy _hitStrategy;
    
    /// <summary>
    /// Get enemy speed.
    /// </summary>
    /// <returns>enemy speed</returns>
    public double Speed => 5.0;

    /// <summary>
    /// AbstractEnemy Constructor.
    /// </summary>
    /// <param name="hearts">max hearts number for the enemy</param>
    /// <param name="movementStrategy">the strategy for the movement</param>
    /// <param name="hitStrategy">the strategy for the hit</param>
    protected AbstractEnemy(double hearts, IMovementStrategy movementStrategy, IHitStrategy hitStrategy)
    {
        _hearts = hearts;
        _coords = new Point2D(FixedInitialPosition, FixedInitialPosition);
        _movementStrategy = movementStrategy;
        _hitStrategy = hitStrategy;
    }

    public void Hit(Point2D playerPosition) => _hitStrategy.Hit(null, this);

    public void Move(Point2D playerPosition) => SetCoords(_movementStrategy.Move(GetCoords(), playerPosition));
    
    public Point2D GetCoords() => new (_coords.X, _coords.Y);

    public void SetCoords(Point2D coords) => _coords = new Point2D(coords.X, coords.Y);

    public bool IsDead() => GetHearts() <= 0;

    public void SetHearts(double damage)
    {
        if (!IsDead()) {
            _hearts -= damage;
        }
    }

    public double GetHearts() => _hearts;

    public List<IWeaponShot> GetWeaponShots() => throw new NotImplementedException();

    public IHitStrategy GetHitStrategy() => _hitStrategy;
    
}