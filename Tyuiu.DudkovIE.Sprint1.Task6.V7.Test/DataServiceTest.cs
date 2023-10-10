using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint1.Task6.V7.Lib;

namespace Tyuiu.DudkovIE.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string wait = ds.DeleteLastLetter("Привет мир");
            Assert.AreEqual("Приве ми ", wait);
        }
    }
}
