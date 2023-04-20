using Isaccoop.Game;
using Isaccoop.Game.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Isaccoop.Test
{
    /// <summary>
    /// Test Class for method in BoundingBox. 
    /// </summary>
    [TestClass]
    public class TestBoundingBox
    {
        /// <summary>
        /// Test of two circle collision.
        /// </summary>
        [TestMethod]
        public void TestCircleBoundingBoxIsCollidingWithCricle()
        {
            var circleBox = new CircleBoundingBox(5);
            var circleBox1 = new CircleBoundingBox(5);
            var center1 = new Point2D(0, 0);
            var center2 = new Point2D(1, 1);
            var center3 = new Point2D(50, 50);

            var result1 = circleBox.IsCollidingWithCricle(center1, center2, circleBox);
            var result2 = circleBox.IsCollidingWithCricle(center1, center3, circleBox1);

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }

        /// <summary>
        /// Test for collision of one circle and one rectangle perimeter.
        /// </summary>
        [TestMethod]
        public void TestCircleBoundingBoxIsCollidingWithRecPerimeter()
        {
            var circleBox = new CircleBoundingBox(6);
            var center = new Point2D(5, 5);
            var center1 = new Point2D(100, 100);
            var rectangleBox = new RectBoundingBox(200, 200);

            var result1 = circleBox.IsCollidingWithRecPerimeter(center, rectangleBox);
            var result2 = circleBox.IsCollidingWithRecPerimeter(center1, rectangleBox);

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }

        /// <summary>
        /// Test for RectangleBoundingBox parameter getter.
        /// </summary>
        [TestMethod]
        public void TestRectBoundingBoxGetWidthAndHeight()
        {
            var rectangleBox = new RectBoundingBox(10, 20);

            var width = rectangleBox.GetWidth();
            var height = rectangleBox.GetHeight();

            Assert.AreEqual(10, width);
            Assert.AreEqual(20, height);
        }
    }
}
