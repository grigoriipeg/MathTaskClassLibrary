using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            int a = 3;
            int b = 5;
            int expected = a * b;

            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CylinderVolumeReturned()
        {
            double pi = 3.14;
            int r = 10;
            int h = 4;
            double expected = (pi * Math.Pow(r, 2) * h);

            Geometry g = new Geometry();
            double actual = g.CylinderVolume(pi, r, h);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareRootReturned()
        {
            double x = 100;
            double expected = Math.Sqrt(x);

            Geometry g = new Geometry();
            double actual = g.SquareRoot(x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EquationReturned()
        {
            double[] test1 = Geometry.Equation(1, 1, 1); // d < 0 return null
            double[] test2 = Geometry.Equation(1, -6, 9); // d = 0 return x1 = 3
            double[] test3 = Geometry.Equation(1, -8, 12); // d > 0 return x1 = 6; x2 = 2

            Assert.AreEqual(test1, null);
            Assert.AreEqual(3, test2[0]);
            Assert.AreEqual(6, test3[0]);
            Assert.AreEqual(2, test3[1]);
        }

        [TestMethod]
        public void SquareOfNumbersReturned()
        {
            int x = 100;
            int expected = 91;

            Geometry g = new Geometry();
            double actual = g.SquareOfNumbers(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
