using Microsoft.VisualStudio.TestTools.UnitTesting;
using Isaccoop.Game;
using Isaccoop.Game.Common;
using System;
using System.Collections.Generic;

namespace Isaccoop.Test
{
    [TestClass]
    public class TestSpawn
    {
        [TestMethod]
        public void SetPosition_OneElement_CenterPosition()
        {
            /// Arrange
            var spawn = new SpawnOrdered();
            var elements = new List<MapElement> { new MapElement() };
            int width = 10;
            int height = 10;

            /// Act
            spawn.SetPosition(elements, width, height);

            /// Assert
            Assert.AreEqual(new Point2D(width / 2.0, height / 2.0), elements[0].Coords);
        }

        [TestMethod]
        public void SetPosition_MultipleElements_OrderedYPositions()
        {
            /// Arrange
            var spawn = new SpawnOrdered();
            var elements = new List<MapElement>
            {
                new MapElement(),
                new MapElement(),
                new MapElement()
            };
            int width = 10;
            int height = 10;

            /// Act
            spawn.SetPosition(elements, width, height);

            /// Assert
            Assert.AreEqual(new Point2D(width / 2.0, height / 4.0), elements[0].Coords);
            Assert.AreEqual(new Point2D(width / 2.0, height / 2.0), elements[1].Coords);
            Assert.AreEqual(new Point2D(width / 2.0, 3 * height / 4.0), elements[2].Coords);
        }

        [TestMethod]
        public void SetPosition_ElementsRandomlyPlacedWithinRoom()
        {
            // Arrange
            var spawn = new SpawnRandom();
            var elements = new List<MapElement>
            {
                new MapElement { Box = new CircleBoundingBox(1) },
                new MapElement { Box = new CircleBoundingBox(2) },
                new MapElement { Box = new CircleBoundingBox(3) }
            };
            int width = 10;
            int height = 10;

            // Act
            spawn.SetPosition(elements, width, height);

            // Assert
            foreach (var element in elements)
            {
                Assert.GreaterOrEqual(element.Coords.X, element.Box.Radius + element.Box.Radius / 2);
                Assert.LessOrEqual(element.Coords.X, width - (element.Box.Radius + element.Box.Radius / 2));
                Assert.GreaterOrEqual(element.Coords.Y, element.Box.Radius + element.Box.Radius / 2);
                Assert.LessOrEqual(element.Coords.Y, height - (element.Box.Radius + element.Box.Radius / 2));
            }
        }
    }
}
