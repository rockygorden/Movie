using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int sum = 1 + 4;
            Assert.AreEqual(3, sum);
        }
    }
}
