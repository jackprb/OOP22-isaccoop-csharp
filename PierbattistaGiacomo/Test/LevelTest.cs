using Microsoft.VisualStudio.TestTools.UnitTesting;
using Isaccoop.Game.Common;
using System.Collections.Generic;
using System;
using Isaccoop.Game;

namespace Test
{
    /// <summary>
    /// <see cref="Level"/> test.
    /// </summary>
    [TestClass]
    public class LevelTest
    {
        // variables for local level
        private Level _localLevel = new Level();
        private List<IRoom> _otherRoomList = new List<IRoom>();

        // variable to store data generated from LevelFactory
        private List<IRoom> _roomListFromFactory = new List<IRoom>();

        [TestInitialize]
        public void TestInitialize()
        {
            // generate a complete level using LevelFactory
            ILevel lvl = new LevelFactory().CreateLevel();
            // get the rooms of that level
            _roomListFromFactory = lvl.GetRooms();
            // put the rooms in the localLevel
            _localLevel.PutRooms(_roomListFromFactory); // the level has no rooms => OK
        }

        [TestMethod]
        public void TestPutRooms()
        {
            var arr = Enum.GetValues(typeof(RoomType));
            // generate another List<Room>, made of 5 rooms, one for each RoomType
            foreach (RoomType roomType in arr)
            {
                _otherRoomList.Add(new RoomFactory(arr.Length)
                        .BuildRoomInProperOrder(new Point2D(((int) roomType), 0)));
            }

            // the level already has rooms (set in method TestInitialize) => throw exception
            Assert.ThrowsException<InvalidOperationException>(() => _localLevel.PutRooms(_otherRoomList));

            // the localLevel must have the correct number of rooms
            Assert.AreEqual(_localLevel.GetRooms().Count, _roomListFromFactory.Count);
        }

        [TestMethod]
        public void TestGetRooms()
        {
            // the List<Room> returned from localLevel is the same in roomListFromFactory
            // so, those lists must be equal
            CollectionAssert.AreEquivalent(_roomListFromFactory, _localLevel.GetRooms());
        }

        [TestMethod]
        public void TestGetStartRoom()
        {
            IRoom startRoom = _localLevel.GetRooms()
                   .Find(r => r.GetRoomType() == RoomType.Start);
            Assert.AreEqual(_localLevel.GetStartRoom().GetRoomType(), startRoom.GetRoomType());
        }
    }
}
