using AreaCalculator;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalculator.tests
{
    [TestClass]
    public class AreaCalculatorTests
    {
        [TestMethod]
        public void GetArea_Test()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expected = 6;

            Calculator calc1 = new Calculator();
            double result = calc1.GetArea(side1, side2, side3);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetArea_Test_byZero()
        {
            double side1 = 0;
            double side2 = 1;
            double side3 = 2;
            
            Calculator calc1 = new Calculator();
            double result = calc1.GetArea(side1, side2, side3);
        }
    }
}
