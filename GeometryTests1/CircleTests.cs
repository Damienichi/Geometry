using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            //arrange
            double radius = 1;
            double expected = Math.PI;

            //act
            Circle circle = new Circle(radius);
            double actual = circle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}