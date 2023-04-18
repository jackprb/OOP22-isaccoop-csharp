namespace Isaccoop.Game{

    /// <summary>
    /// The class for player movement.
    /// </summary>
    public class PlayerMovementImpl : MapElement, PlayerStatImpl
    {
        /// <summary>
        /// PlayerMovement constructor.
        /// </summary>
        public PlayerMovementImpl()
        {
            base();
        }

        /// <inheritdoc cref="IPlayerMovement" />
        public void Update(readonly Direction direction) => base.SetCoords(GetMovePreview(direction));

        /// <inheritdoc cref="IPlayerMovement" />
        public Point2D GetMovePreview(readonly Direction direction)
        {
            double distance = base.Speed();
            double x = base.GetCoords().X();
            double y = base.GetCoords().Y();
            switch(direction) 
            {
            case UP:
                    return new Point2D(x, y - distance);
                break;
            case RIGHT:
                    return new Point2D(x + distance, y);
                break;
            case DOWN:
                    return new Point2D(x, y + distance);
                break;
            case LEFT:
                    return new Point2D(x - distance, y);
                break;
            default:
                    return new Point2D(x, y);
                break;
            }
        }
    }

}