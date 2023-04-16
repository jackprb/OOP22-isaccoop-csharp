using Microsoft.VisualStudio.TestTool.UnitTesting;
using Isaccoop.Model.Common;
using Isaccoop.Model.Spawn;
using System.Collections.Generic;

namespace Isaccoop.Model.Tests.Spawn
{
    [TestFixture]
    public class SpawnOrderedTests
    {
        [Test]
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

        [Test]
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
    }
}
