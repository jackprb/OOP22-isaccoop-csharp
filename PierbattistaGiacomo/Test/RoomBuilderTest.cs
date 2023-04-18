using Microsoft.VisualStudio.TestTools.UnitTesting;
using Isaccoop.Game.Common;
using System;
using Isaccoop.Game;

namespace Test
{
    /// <summary>
    /// <see cref="RoomBuilder"/> test.
    /// </summary>
    [TestClass]
    public class RoomBuilderTest
    {
        private static readonly int RoomWidth = 300;
        private static readonly int RoomHeight = 200;
        private static readonly int MaxCoordNumber = 20;

        [TestMethod]
        public void TestPutCoord()
        {
            RoomBuilder.Builder emptyBuilder = CreateBuilder();
            RoomBuilder.Builder ris = emptyBuilder.PutCoord(GenerateCoord());
            Assert.AreEqual(ris, emptyBuilder);
        }

        [TestMethod]
        public void TestRoomType()
        {
            foreach (RoomType rType in Enum.GetValues(typeof(RoomType)))
            {
                RoomBuilder.Builder emptyBuilder = CreateBuilder();
                RoomBuilder.Builder ris = emptyBuilder.RoomType(rType);
                Assert.AreEqual(ris, emptyBuilder);
            }
        }

        [TestMethod]
        public void TestPutItems()
        {
            foreach (RoomType rType in Enum.GetValues(typeof(RoomType)))
            {
                RoomBuilderUtils utils = new RoomBuilderUtils(rType);
                RoomBuilder.Builder localBuilder = new RoomBuilder.Builder(RoomWidth, RoomHeight)
                        .PutCoord(GenerateCoord())
                        .RoomType(rType);
                if (utils.CanRoomHaveItems())
                {
                    Assert.AreEqual(localBuilder.PutItems(), localBuilder);
                } 
                else
                {
                    Assert.ThrowsException<InvalidOperationException>(() => localBuilder.PutItems());
                }
            }
        }

        [TestMethod]
        public void TestPutEnemies()
        {
            foreach (RoomType rType in Enum.GetValues(typeof(RoomType)))
            {
                RoomBuilderUtils utils = new RoomBuilderUtils(rType);
                RoomBuilder.Builder localBuilder = new RoomBuilder.Builder(RoomWidth, RoomHeight)
                        .PutCoord(GenerateCoord())
                        .RoomType(rType);
                if (utils.CanRoomHaveEnemies())
                {
                    Assert.AreEqual(localBuilder.PutEnemies(), localBuilder);
                }
                else
                {
                    Assert.ThrowsException<InvalidOperationException>(() => localBuilder.PutEnemies());
                }
            }
        }

        [TestMethod]
        public void TestPutPowerUps()
        {
            foreach (RoomType rType in Enum.GetValues(typeof(RoomType)))
            {
                RoomBuilderUtils utils = new RoomBuilderUtils(rType);
                RoomBuilder.Builder localBuilder = new RoomBuilder.Builder(RoomWidth, RoomHeight)
                        .PutCoord(GenerateCoord())
                        .RoomType(rType);
                if (utils.CanRoomHavePowerUps())
                {
                    Assert.AreEqual(localBuilder.PutPowerUps(), localBuilder);
                }
                else
                {
                    Assert.ThrowsException<InvalidOperationException>(() => localBuilder.PutPowerUps());
                }
            }
        }

        [TestMethod]
        public void TestBuild()
        {
            RoomBuilder.Builder localBuilder = new RoomBuilder.Builder(RoomWidth, RoomHeight)
                    .PutCoord(GenerateCoord());
            // build() at this point will throw an exception because each room
            // must have a RoomType
            Assert.ThrowsException<InvalidOperationException>(() => localBuilder.Build());

            foreach (RoomType rType in Enum.GetValues(typeof(RoomType)))
            {
                RoomBuilder.Builder otherBuilder = new RoomBuilder.Builder(RoomWidth, RoomHeight)
                        .RoomType(rType);

                // build() at this point will throw an exception because each room
                // must have a coordinate
                Assert.ThrowsException<InvalidOperationException>(() => otherBuilder.Build());
            }

            // previous tests check if a room is created correctly, using the correct methods
            // so such tests are not repeated here
        }

        /// <summary>
        /// Utility method to create a new builder.
        /// </summary>
        /// <returns> a new builder</returns>
        private RoomBuilder.Builder CreateBuilder() =>
            new(new Random().Next(RoomWidth), new Random().Next(RoomHeight));

        /// <summary>
        /// Utility method to generate a new random <see cref="Point2D"/>.
        /// </summary>
        /// <returns> a new Point2D </returns>
        private Point2D GenerateCoord() =>
            new(new Random().Next(MaxCoordNumber), new Random().Next(MaxCoordNumber));
    }
}
