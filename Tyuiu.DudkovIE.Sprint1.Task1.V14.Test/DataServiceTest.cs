using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint1.Task1.V14.Lib;

namespace Tyuiu.DudkovIE.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 1;
            double b = 1;
            double c = 1;
            double res = ds.Calculate(a, b, c);
            Assert.AreEqual(1.5, res);
        }
    }
}
