using System;
using KFC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var page = new MenuWindow();
            Assert.AreNotEqual(page.Itogg(), null);
            Assert.AreEqual(page.PoDerevenski(), 79);
            Assert.AreEqual(page.BigBurger(), 294);
            Assert.AreEqual(page.ZingerBurger(), 404);
            Assert.AreEqual(page.HotSandersBurger(), 539);
            Assert.AreEqual(page.SandersBurger(), 674);
            Assert.AreEqual(page.BlackBurger(), 824);
            Assert.AreEqual(page.ChiefBurger(), 994);
        }
    }
}
