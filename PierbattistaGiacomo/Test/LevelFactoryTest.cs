using Isaccoop.Game.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Isaccoop.Game;

namespace Test
{
    /// <summary>
    /// <see cref="LevelFactory"/> test.
    ///  This test is meant to check if a level is built correctly using <see cref="LevelFactory"/>.
    /// </summary>
    [TestClass]
    public class LevelFactoryTest
    {
        private static readonly int MaxNumberOfRooms = 30;
        private static readonly int MinNumberOfRooms = 6;
        private static readonly int SingleRoomCount = 1;
        private static readonly int NonStandardRoomCount = 4;

        private readonly LevelFactory _lvlFactory = new LevelFactory();
        private ILevel _lvl;
        private List<IRoom> _rooms;

        [TestInitialize]
        public void TestInitialize()
        {
            _lvl = _lvlFactory.CreateLevel();
            _rooms = _lvl.GetRooms();
        }

        [TestMethod]
        public void TestRoomCreation()
        {
            // check if a just created level has the correct number of rooms
            Assert.IsTrue(_rooms.Count < MaxNumberOfRooms && _rooms.Count >= MinNumberOfRooms);
        }

        [TestMethod]
        public void TestRoomTypeCount()
        {
            // in a level, there must be ONLY ONE START, ONE SHOP, ONE TREASURE and ONE BOSS room
            Assert.AreEqual(_rooms
                    .FindAll(r  =>  r.GetRoomType() == RoomType.Start)
                    .Count, SingleRoomCount);
            Assert.AreEqual(_rooms
                    .FindAll(r => r.GetRoomType() == RoomType.Shop)
                    .Count, SingleRoomCount);
            Assert.AreEqual(_rooms
                    .FindAll(r => r.GetRoomType() == RoomType.Treasure)
                    .Count, SingleRoomCount);
            Assert.AreEqual(_rooms
                    .FindAll(r => r.GetRoomType() == RoomType.Boss)
                    .Count, SingleRoomCount);

            // in a level, the remaining rooms must be STANDARD
            Assert.AreEqual(_rooms
                    .FindAll(r => r.GetRoomType() == RoomType.Standard)
                    .Count, _rooms.Count - NonStandardRoomCount);
        }
    }
}
