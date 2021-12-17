using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Math.Round(Math.Atan(0.1 * Math.PI / 180), 4),
            Math.Round(rabota1.Program.Ass(0.1 * Math.PI / 180), 4));
        }
    }
}
