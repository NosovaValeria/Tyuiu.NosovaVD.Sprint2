using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint2.Task6.V8.Lib;
namespace Tyuiu.NosovaVD.Sprint2.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            Assert.AreEqual("19.5", ds.FindDateOfPreviousDay(5, 20));
            Assert.AreEqual("31.3", ds.FindDateOfPreviousDay(4, 1));
            Assert.AreEqual("29.7", ds.FindDateOfPreviousDay(7, 30));
            Assert.AreEqual("31.8", ds.FindDateOfPreviousDay(9, 1));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(14, 32);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfPreviousDay(13, 32);
            });
        }
    }
}
