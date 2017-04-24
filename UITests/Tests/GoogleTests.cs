using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UITests.Tests
{
    [TestClass]
    public class GoogleTests : BaseTest
    {
        [TestMethod]
        public void GoogleTest()
        {
            _driver.Navigate().GoToUrl("https://www.google.ro");

            Assert.IsTrue(_driver.Title == "Google");
        }
    }
}
