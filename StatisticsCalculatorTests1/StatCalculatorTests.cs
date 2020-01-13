using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operation;
using StatisticsCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsCalculator.Tests
{
    [TestClass()]
    public class StatCalculatorTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            StatCalculator statCalc = new StatCalculator();
            int[] values = { 1, 2, 3, 4 };
            //int c = statCalc.Mean(1,4,5,6,2);
            //Assert.AreEqual(6, c);
            var mean = statCalc.Mean(values);
            Assert.AreEqual(2, mean);
        }

        [TestMethod()]
        public void VarianceTest()
        {
            StatCalculator statCalc = new StatCalculator();
            int[] values = { 1, 2, 3 };
            var variance = statCalc.Variance(values);
            Assert.AreEqual(0.67, variance);
        }

        [TestMethod()]
        public void StandardDTest()
        {
            StatCalculator statCalc = new StatCalculator();
            int[] values = { 1, 2, 3 };
            //dynamic values = statCalc.Squarea(0.67);
            var standDev = statCalc.StandardD(values);
            Assert.AreEqual(SuareRoot.Root(0.67), standDev);
            
        }
    }
}