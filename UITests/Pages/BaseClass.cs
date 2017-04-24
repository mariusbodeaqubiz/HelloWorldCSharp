using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests.Pages
{
    public class BaseClass
    {
        public IWebDriver _driver;

        public BaseClass(IWebDriver driver)
        {
            _driver = driver;
            OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(_driver, this);
        }
    }
}
