using System;
using azureTestApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace azureUnitTestProject
{
    [TestClass]
    public class CalculatorUnitTest
    {
        Calculator calculator = null;

        [TestInitialize]
        public void Initialize()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void testSum()
        {
            Assert.AreEqual(4, calculator.sum(2, 2));    
        }

        [TestMethod]
        public void testSubstract()
        {
            Assert.AreEqual(10, calculator.substract(20, 10));
        }

        [TestMethod]
        public void testMultiply()
        {
            Assert.AreEqual(6, calculator.multiply(2, 3));
        }

        [TestMethod]
        public void testDivide()
        {
            Assert.AreEqual(120, calculator.divide(480, 4));
        }
    }
}
