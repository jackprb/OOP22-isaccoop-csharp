using Isaccoop.Game.Common;

namespace Isaccoop.Game;

public class AbstractEnemy : IMapElement, IEnemy
{
    
    private const double FixedInitialPosition = 10.0;
    private const double Speed = 5.0;
    
    private Point2D _coords;
    private double _hearts;
    private readonly IMovementStrategy _movementStrategy;
    private readonly IHitStrategy _hitStrategy;

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

    public List<IWeaponShot>? GetWeaponShots() => throw new NotImplementedException();

    public IHitStrategy GetHitStrategy() => _hitStrategy;

    public double GetSpeed() => Speed;
}