using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests.Tests
{
    [TestClass]
    public class BaseTest
    {
        public IWebDriver _driver;

        [TestInitialize]
        public void BrowserInitialization()
        {
            var options = new ChromeOptions();
            options.AddArgument("--disable-extensions");
            options.AddArgument("--incognito");

            // Set relative path for chromedriver.exe
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(currentDir);
            Console.WriteLine(directory.ToString() + "\\Drivers\\");

            // _driver = new ChromeDriver("Drivers", options);

            _driver = new FirefoxDriver();

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
