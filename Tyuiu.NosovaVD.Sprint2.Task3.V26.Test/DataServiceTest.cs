using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint2.Task3.V26.Lib;
namespace Tyuiu.NosovaVD.Sprint2.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            Assert.AreEqual(4.702,res);
        }
        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            Assert.AreEqual(1.667, res);
        }
        [TestMethod]
        public void ValidExpression3()
        {
            DataService ds = new DataService();
            double x = -2;
            double res = ds.Calculate(x);
            Assert.AreEqual(9.195, res);
        }
        [TestMethod]
        public void ValidExpression4()
        {
            DataService ds = new DataService();
            double x = -32;
            double res = ds.Calculate(x);
            Assert.AreEqual(-255.969, res);
        }
    }
}
