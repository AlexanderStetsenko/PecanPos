using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PecanTest.Framework.DriverWrapper
{
    public class DriverWrapper : RemoteWebDriver
    {
        ChromeDriver driver;

        public DriverWrapper(ChromeDriver driver, DriverOptions options) : base(options)
        {
            this.driver = driver;
        }

        public IWebElement FindElement(By by) {
            
            return driver.FindElement(by);
        }
       
        public IWebElement FindElementByClassName(string className)
        {
            return driver.FindElementByClassName(className);
        }
       
        public IWebElement FindElementByCssSelector(string cssSelector)
        {
            return driver.FindElementByCssSelector(cssSelector);
        }

        public IWebElement FindElementById(string id)
        {
            return driver.FindElementById(id);

        }

        public IWebElement FindElementByLinkText(string linkText)
        {
            return driver.FindElementByLinkText(linkText);

        }

        public IWebElement FindElementByName(string name)
        {
            return driver.FindElementByName(name);
        }

        public IWebElement FindElementByPartialLinkText(string partialLinkText)
        {
            return driver.FindElementByPartialLinkText(partialLinkText);
        }

        public IWebElement FindElementByTagName(string tagName)
        {
            return driver.FindElementByTagName(tagName);

        }

        public IWebElement FindElementByXPath(string xpath)
        {
            return driver.FindElementByXPath(xpath);

        }
    }
}
