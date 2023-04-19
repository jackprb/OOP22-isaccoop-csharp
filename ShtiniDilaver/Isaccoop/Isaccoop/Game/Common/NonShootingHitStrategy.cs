using System;

namespace Isaccoop.Game.Common
{

    public class NonShootingHitStrategy : IHitStrategy
    {
        private bool _canHit;

        public NonShootingHitStrategy()
        {
            _canHit = false;
        }

        public void Hit(Vector2D direction, IMapElement caller)
        {
            throw new NotImplementedException();
        }

        public bool CanHit()
        {
            return _canHit;
        }
    }
}