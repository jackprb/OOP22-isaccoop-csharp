using Microsoft.VisualStudio.TestTools.UnitTesting;
using Isaccoop.Game;
using System;

namespace Isaccoop.Test
{
    /// <summary>
    /// Class to test item.
    /// </summary>
    [TestClass]
    class TestItem 
    {
        private readonly IPlayerStat _stat = new PlayerStatImpl();
        private readonly IItem _coin = new Coin();
        private readonly IItem _heart = new Heart();
        private readonly PowerUp _damageUp = new DamageUp();
        private readonly PowerUp _healthUp = new HealthUp();
        private readonly PowerUp _speedUp = new SpeedUp();

        /// <summary>
        /// Test function for power ups.
        /// </summary>
        [TestMethod]
        void TestPowerUp() {
            Assert.AreEqual(1.0, _stat.Damage);
            _damageUp.SuperItem = true;
            _damageUp.Interact(_stat);
            Assert.AreEqual(3.0, _stat.Damage);
            _damageUp.SuperItem = false;
            _damageUp.Interact(_stat);
            Assert.AreEqual(4.0, _stat.Damage);

            Assert.AreEqual(3, _stat.MaxHeart);
            _healthUp.SuperItem = false;
            _healthUp.Interact(_stat);
            Assert.AreEqual(4, _stat.MaxHeart);

            Assert.AreEqual(1, _stat.Speed);
            _speedUp.SuperItem = true;
            _speedUp.Interact(_stat);
            Assert.AreEqual(2, _stat.Speed);

        }

        /// <summary>
        /// Test function for basic items.
        /// </summary>
        [TestMethod]
        void TestItemStandard() {
            _coin.Interact(_stat);
            Assert.AreEqual(1, _stat.Coin);

            Assert.AreEqual(3, _stat.Heart);
            _heart.Interact(_stat);
            Assert.AreEqual(3, _stat.Heart);
        }
    }
}
