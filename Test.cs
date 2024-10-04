using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Interview_task
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void TestCalculateArea(double radius)
        {
            var expectedResult = Math.PI * Math.Pow(radius, 2);
            var actualResult = new Circle(radius).CalculateArea();

            Assert.AreEqual(expectedResult, actualResult, 0.00001);
        }
    }

    [TestFixture]
    public class RectangleTests
    {
        [TestCase(3, 4, 5)]
        [TestCase(1, 1, 1)]
        [TestCase(2, 3, 4)]
        public void TestCalculateArea(double side1, double side2, double side3)
        {
            var triangle = new Rectangle(side1, side2, side3);
            double perimeter = (side1 + side2 + side3) / 2;
            var expectedResult = Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));
            var actualResult = triangle.CalculateArea();

            Assert.AreEqual(expectedResult, actualResult, 0.00001);
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(1, 1, 1, false)]
        [TestCase(2, 3, 4, false)]
        public void TestIsTriangleRectangular(double side1, double side2, double side3, bool check)
        {
            var triangle = new Rectangle(side1, side2, side3);
            var expectedResult = check;
            var actualResult = triangle.IsTriangleRectangular();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
