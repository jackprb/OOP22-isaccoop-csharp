using Microsoft.VisualStudio.TestTools.UnitTesting;
using Isaccoop.Game.Common;
using System.Collections.Generic;
using System;

namespace Isaccoop.Game.Test {
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
        private IList<IRoom> _roomListFromFactory = new List<IRoom>();

        [TestInitialize]
        public void SetUp()
        {
            // generate a complete level using LevelFactory
            ILevel lvl = new LevelFactory().CreateLevel();
            // get the rooms of that level
            _roomListFromFactory = lvl.GetRooms();
            // put the rooms in the localLevel
            _localLevel.PutRooms(_roomListFromFactory); // the level has no rooms => OK
        }

        
    }
}
