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
            var elements = new List<IMapElement> { new MapElement(MapElement.ElementsRadius.BOSS) };
            int width = 500;
            int height = 500;

            /// Act
            spawn.SetPosition(elements, width, height);

            /// Assert
            Assert.AreEqual(new Point2D(width / 2.0, height / 2.0), elements[0].GetCoords());
        }

        [TestMethod]
        public void SetPosition_MultipleElements_OrderedYPositions()
        {
            /// Arrange
            var spawn = new SpawnOrdered();
            var elements = new List<IMapElement>
            {
                new MapElement(MapElement.ElementsRadius.BOSS),
                new MapElement(MapElement.ElementsRadius.BOSS),
                new MapElement(MapElement.ElementsRadius.BOSS)
            };
            int width = 500;
            int height = 500;

            /// Act
            spawn.SetPosition(elements, width, height);

            /// Assert
            Assert.AreEqual(new Point2D(width / 2.0, height / 4.0), elements[0].GetCoords());
            Assert.AreEqual(new Point2D(width / 2.0, height / 2.0), elements[1].GetCoords());
            Assert.AreEqual(new Point2D(width / 2.0, 3 * height / 4.0), elements[2].GetCoords());
        }

        [TestMethod]
        public void SetPosition_ElementsRandomlyPlacedWithinRoom()
        {
            // Arrange
            var spawn = new SpawnRandom();
            var elements = new List<IMapElement>
            {
                new MapElement(MapElement.ElementsRadius.PLAYER),
                new MapElement(MapElement.ElementsRadius.ENEMY),
                new MapElement(MapElement.ElementsRadius.PLAYER)
            };
            int width = 500;
            int height = 500;

            // Act
            spawn.SetPosition(elements, width, height);

            // Assert
            foreach (var element in elements)
            {
                var radius = ((CircleBoundingBox)element.GetBox()).GetRadius();
                Assert.IsTrue(element.GetCoords().X > radius);
                Assert.IsTrue(element.GetCoords().X < width - radius);
                Assert.IsTrue(element.GetCoords().Y > radius);
                Assert.IsTrue(element.GetCoords().Y < height - radius);
            }
        }
    }
}
