using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            //arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expected = 6;

            //act
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double actual = triangle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}