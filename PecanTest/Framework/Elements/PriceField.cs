using NUnit.Framework;
using OpenQA.Selenium;
using PecanTest.Framework.Interfaces;
using PecanTest.Framework.ScreenObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PecanTest.Framework.Elements
{
    public class PriceField : InputField, IPriceField
    {

        public PriceField(string name, By path) : base(name, path)
        {
        }
        public PriceField(string name, By path, Element parent) : base(name, path, parent)
        {
        }
        public PriceField(string name, By path, Element parent, int maxChar) : base(name, path, parent)
        {
            this.maxChar = maxChar;
        }


        public void CheckThatPriceField()
        {
            Clear();
            CheckFillWithNegative();
            Clear();
            CheckFillAlphabetic();
            CheckMaxChars();
        }

        private void CheckFillAlphabetic()
        {
            SendKeysAlphabetic(5);
            Assert.AreEqual(String.Empty, driver.FindElement(path).GetAttribute("value"));
        }
        private void CheckFillWithNegative()
        {
            Assert.AreEqual(SendKeysNum(5), driver.FindElement(path).GetAttribute("value"));
        }
    }   
}
