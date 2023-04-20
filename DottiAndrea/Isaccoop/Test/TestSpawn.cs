using Microsoft.VisualStudio.TestTools.UnitTesting;
using Isaccoop.Game;
using Isaccoop.Game.Common;
using System;
using System.Collections.Generic;

namespace Isaccoop.Test
{
    /// <summary>
    /// Test Class for the Spawn.
    /// </summary>
    [TestClass]
    public class TestSpawn
    {
        /// <summary>
        /// Test for an ordered Spawn of one element.
        /// </summary>
        [TestMethod]
        public void SetPosition_OneElement_CenterPosition()
        {
            var spawn = new SpawnOrdered();
            var elements = new List<IMapElement> { new MapElement(MapElement.ElementsRadius.BOSS) };
            int width = 500;
            int height = 500;

            spawn.SetPosition(elements, width, height);

            Assert.AreEqual(new Point2D(width / 2.0, height / 2.0), elements[0].GetCoords());
        }

        /// <summary>
        /// Test for an ordered Spawn of multiple elements.
        /// </summary>
        [TestMethod]
        public void SetPosition_MultipleElements_OrderedYPositions()
        {
            var spawn = new SpawnOrdered();
            var elements = new List<IMapElement>
            {
                new MapElement(MapElement.ElementsRadius.BOSS),
                new MapElement(MapElement.ElementsRadius.BOSS),
                new MapElement(MapElement.ElementsRadius.BOSS)
            };
            int width = 500;
            int height = 500;

            spawn.SetPosition(elements, width, height);

            Assert.AreEqual(new Point2D(width / 2.0, height / 4.0), elements[0].GetCoords());
            Assert.AreEqual(new Point2D(width / 2.0, height / 2.0), elements[1].GetCoords());
            Assert.AreEqual(new Point2D(width / 2.0, 3 * height / 4.0), elements[2].GetCoords());
        }

        /// <summary>
        /// Test for a random Spawn of multiple elements.
        /// </summary>
        [TestMethod]
        public void SetPosition_ElementsRandomlyPlacedWithinRoom()
        {
            var spawn = new SpawnRandom();
            var elements = new List<IMapElement>
            {
                new MapElement(MapElement.ElementsRadius.PLAYER),
                new MapElement(MapElement.ElementsRadius.ENEMY),
                new MapElement(MapElement.ElementsRadius.PLAYER)
            };
            int width = 500;
            int height = 500;

            spawn.SetPosition(elements, width, height);

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
