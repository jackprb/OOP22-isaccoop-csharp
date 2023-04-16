using NUnit.Framework;
using it.unibo.isaccoop.model.boundingbox;
using it.unibo.isaccoop.model.common;

namespace it.unibo.isaccoop.test
{
    [TestFixture]
    public class TestBoundingBox
    {
        [Test]
        public void TestCircleBoundingBoxIsCollidingWithCricle()
        {
            // Arrange
            var circleBox = new CircleBoundingBox(5);
            var center1 = new Point2D(0, 0);
            var center2 = new Point2D(15, 15);

            // Act
            var result1 = circleBox.IsCollidingWithCricle(center1, center2, circleBox);
            var result2 = circleBox.IsCollidingWithCricle(center1, center2, new CircleBoundingBox(10));

            // Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }

        [Test]
        public void TestCircleBoundingBoxIsCollidingWithRecPerimeter()
        {
            // Arrange
            var circleBox = new CircleBoundingBox(5);
            var center = new Point2D(5, 5);
            var rectangleBox = new RectBoundingBox(10, 10);

            // Act
            var result1 = circleBox.IsCollidingWithRecPerimeter(center, rectangleBox);
            var result2 = circleBox.IsCollidingWithRecPerimeter(new Point2D(20, 20), rectangleBox);

            // Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }

        [Test]
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

        [Test]
        public void TestRectBoundingBoxIsCollidingWithCricle()
        {
            // Arrange
            var rectangleBox = new RectBoundingBox(10, 20);
            var center1 = new Point2D(0, 0);
            var center2 = new Point2D(15, 25);
            var circleBox = new CircleBoundingBox(5);

            // Act
            var result1 = rectangleBox.isCollidingWithCricle(center1, center2, circleBox);
            var result2 = rectangleBox.isCollidingWithCricle(center1, center2, new CircleBoundingBox(10));

            // Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }

        [Test]
        public void TestRectBoundingBoxIsCollidingWithRecPerimeter()
        {
            // Arrange
            var rectangleBox1 = new RectBoundingBox(10, 20);
            var rectangleBox2 = new RectBoundingBox(5, 5);
            var center1 = new Point2D(5, 5);
            var center2 = new Point2D(15, 25);

            // Act
            var result1 = rectangleBox1.isCollidingWithRecPerimeter(center1, rectangleBox2);
            var result2 = rectangleBox1.isCollidingWithRecPerimeter(center2, rectangleBox2);

            // Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}
