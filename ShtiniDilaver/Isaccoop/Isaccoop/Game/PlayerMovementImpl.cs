using Isaccoop.Game.Common;
using System;

namespace Isaccoop.Game{

    /// <summary>
    /// The class for player movement.
    /// </summary>
    public class PlayerMovementImpl : PlayerStatImpl, IPlayerMovement
    {
        /// <summary>
        /// PlayerMovement constructor.
        /// </summary>

        /// <inheritdoc cref="IPlayerMovement" />
        public void Update(Direction direction) => base.SetCoords(GetMovePreview(direction));

        /// <inheritdoc cref="IPlayerMovement" />
        public Point2D GetMovePreview(Direction direction)
        {
            double distance = base.Speed;
            double x = base.GetCoords().X;
            double y = base.GetCoords().Y;
            
            if(direction.X == 0.0 && direction.Y == -1.0) { 
                return new Point2D(x, y - distance);
            }else if (direction.X == 1.0 && direction.Y == 0.0) { 
                return new Point2D(x + distance, y);
            }else if (direction.X == 0.0 && direction.Y == +1.0) { 
                return new Point2D(x, y + distance);
            }else if (direction.X == -1.0 && direction.Y == 0.0) { 
                return new Point2D(x - distance, y);
            }else { 
                return new Point2D(x, y);
            }

        }
    }

}