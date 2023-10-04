using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint1.Task2.V19.Lib;
namespace Tyuiu.DudkovIE.Sprint1.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.ConvertInchToKm(39);

            Assert.AreEqual(1, res);
        }
    }
}
