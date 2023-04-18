using Isaccoop.Game;
using Isaccoop.Game.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Isaccoop.Test
{
    [TestClass]
    public class TestBoundingBox
    {
        [TestMethod]
        public void TestCircleBoundingBoxIsCollidingWithCricle()
        {
            // Arrange
            var circleBox = new CircleBoundingBox(5);
            var circleBox1 = new CircleBoundingBox(5);
            var center1 = new Point2D(0, 0);
            var center2 = new Point2D(1, 1);
            var center3 = new Point2D(50, 50);

            // Act
            var result1 = circleBox.IsCollidingWithCricle(center1, center2, circleBox);
            var result2 = circleBox.IsCollidingWithCricle(center1, center3, circleBox1);

            // Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }

        [TestMethod]
        public void TestCircleBoundingBoxIsCollidingWithRecPerimeter()
        {
            // Arrange
            var circleBox = new CircleBoundingBox(6);
            var center = new Point2D(5, 5);
            var center1 = new Point2D(100, 100);
            var rectangleBox = new RectBoundingBox(200, 200);

            // Act
            var result1 = circleBox.IsCollidingWithRecPerimeter(center, rectangleBox);
            var result2 = circleBox.IsCollidingWithRecPerimeter(center1, rectangleBox);

            // Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }

        [TestMethod]
        public void TestRectBoundingBoxGetWidthAndHeight()
        {
            // Arrange
            var rectangleBox = new RectBoundingBox(10, 20);

            // Act
            var width = rectangleBox.GetWidth();
            var height = rectangleBox.GetHeight();

            // Assert
            Assert.AreEqual(10, width);
            Assert.AreEqual(20, height);
        }
    }
}
