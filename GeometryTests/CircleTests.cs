using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;
using System;

namespace GeometryTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetArea_1_return3_14()
        {
            //arange
            double radius = 1;
            double expected = Math.PI;

            //act
            Circle circle = new Circle(radius);
            double actual = circle.GetArea();

            //asert
            Assert.AreEqual(expected, actual);

        }
    }
}
