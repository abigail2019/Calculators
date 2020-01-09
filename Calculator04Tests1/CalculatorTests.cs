using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calcu = new Calculator();
            int c = calcu.Add(1, 5);
            Assert.AreEqual(6, c);
        }

        [TestMethod()]
        public void DividedTest()
        {
            Calculator calcu = new Calculator();
            int c = calcu.Divided(10, 5);
            Assert.AreEqual(2, c);
        }

        [TestMethod()]
        public void Cubed2Test()
        {
            Calculator calcu = new Calculator();
            int c = calcu.Cubed2(5);
            Assert.AreEqual(125, c);
        }

        [TestMethod()]
        public void TimeTest()
        {
            Calculator calcu = new Calculator();
            int c = calcu.Time(1, 5);
            Assert.AreEqual(5, c);
        }

        [TestMethod()]
        public void SquareaTest()
        {
            Calculator calcu = new Calculator();
            int c = calcu.Squarea(5);
            Assert.AreEqual(25, c);
        }

        [TestMethod()]
        public void SquaredTest()
        {
            Calculator calcu = new Calculator();
            double c = calcu.Squared(16);
            Assert.AreEqual(4, c);
        }

        [TestMethod()]
        public void SubtractedTest()
        {
            Calculator calcu = new Calculator();
            int c = calcu.Subtracted(5, 1);
            Assert.AreEqual(4, c);
        }
    }
}