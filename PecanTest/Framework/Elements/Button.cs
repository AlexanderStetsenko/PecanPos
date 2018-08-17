using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PecanTest.Framework.ScreenObjects
{
    public class Button : Element
    {
        public Button(string name, By path) : base(name, path)
        {
        }
        public Button(string name, By path, Element parent) : base(name, path, parent)
        {
        }

        public void Click()
        {
            try
            {
                GetWebElement().Click();
            }
            catch
            {
                driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0,0,10);
                GetWebElement().Click();
                driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 0);
            }

        }
    }
}