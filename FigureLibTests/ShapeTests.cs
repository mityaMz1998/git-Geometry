using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureLib;
using System;

namespace FigureLibTests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(5);
            double expectedArea = Math.PI * 25;
            Assert.AreEqual(expectedArea, circle.GetArea());
        }

        [TestMethod]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            Assert.AreEqual(expectedArea, triangle.GetArea());
        }

        [TestMethod]
        public void RightTriangleCheck()
        {
            Triangle rightTriangle = new Triangle(3, 4, 5);
            Assert.IsTrue(rightTriangle.IsRightTriangle());
        }

        [TestMethod]
        public void NonRightTriangleCheck()
        {
            Triangle nonRightTriangle = new Triangle(3, 4, 6);
            Assert.IsFalse(nonRightTriangle.IsRightTriangle());
        }
    }
}
