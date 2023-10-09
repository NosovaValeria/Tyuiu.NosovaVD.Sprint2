using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint2.Task1.V26.Lib;
namespace Tyuiu.NosovaVD.Sprint2.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 654;
            int b = 671;
            int c = 874;
            int d = 137;
            bool[] res = ds.GetLogicOperations(a,b,c,d);
            bool[] prov = { true, true, true, false, true, false };
            CollectionAssert.AreEqual(prov, res);
        }
    }
}
