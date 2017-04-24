using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests.Tests
{
    public class BaseTest
    {
        public IWebDriver _driver;

        [TestInitialize]
        public void BrowserInitialization()
        {
            var options = new ChromeOptions();
            options.AddArgument("--disable-extensions");
            options.AddArgument("--incognito");
            _driver = new ChromeDriver("Drivers", options);

            // In case we want to maximize the window size
            //_driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}
