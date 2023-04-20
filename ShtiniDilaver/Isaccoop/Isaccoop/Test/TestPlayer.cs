using Isaccoop.Game.Common;
using Isaccoop.Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Isaccoop.Test{
    ///<summary>
    /// The class for test the player
    ///</summary>
    [TestClass]
    public class TestPlayer
    {
        private readonly Player Player = new();
        private static readonly double START_POSITION = 10.0;

        ///<summary>
        /// Testing the player movement.
        ///</summary>
        [TestMethod]
        public void TestMovement()
        {
            Point2D Pos = Player.GetCoords();
            Assert.AreEqual(new Point2D(START_POSITION, START_POSITION), Pos);
        
            Player.Update(Direction.Up);
            Point2D UpPos = Player.GetCoords();
            Assert.AreEqual(new Point2D(START_POSITION, START_POSITION - Player.Speed), UpPos);
        
            Player.Update(Direction.Right);
            Player.Update(Direction.Right);
            Point2D RightPos = Player.GetCoords();
            Assert.AreEqual(new Point2D(START_POSITION + Player.Speed*2, START_POSITION - Player.Speed), RightPos);
        
            Player.Update(Direction.Left);
            Point2D LeftPos = Player.GetCoords();
            Assert.AreEqual(new Point2D(START_POSITION + Player.Speed, START_POSITION - Player.Speed), LeftPos);
        
            Player.Update(Direction.Down);
            Point2D DownPos = Player.GetCoords();
            Assert.AreEqual(new Point2D(START_POSITION + Player.Speed, START_POSITION), DownPos);
        }
    }
}