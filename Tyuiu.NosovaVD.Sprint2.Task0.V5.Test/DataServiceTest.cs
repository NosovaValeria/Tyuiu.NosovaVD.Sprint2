using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint2.Task0.V5.Lib;
namespace Tyuiu.NosovaVD.Sprint2.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressoin()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 223;
            bool[] res = ds.GetCompareOperations(x, y);
            bool[] prov = { false, true, true, true, false, true };
            CollectionAssert.AreEqual(prov, res);
        }
    }
}
