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
    public class InputField : Field, IInput
    {
        public int maxChar;

        public InputField(string name, By path) : base(name, path)
        {
        }
        public InputField(string name, By path, int maxChar) : base(name, path)
        {
            this.maxChar = maxChar;
        }
        public InputField(string name, By path, Element parent) : base (name, path, parent) {

        }
        public InputField(string name, By path, Element parent, int maxChar) : base(name, path, parent)
        {
            this.maxChar = maxChar;
        }

        public void CheckMaxChars()
        {
            if (maxChar > 0)
            {
                var _inputField = driver.FindElement(path);
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(SendKeysToInput(maxChar).Length, _inputField.GetAttribute("value").Length); // check that max chars are entered to a input
                    _inputField.Clear();
                    Assert.AreEqual(SendKeysToInput(maxChar + 1).Length - 1, _inputField.GetAttribute("value").Length); // check that more then max chars number can't be entered 
                    _inputField.Clear();
                    Assert.AreEqual(SendKeysToInput(maxChar - 1).Length, _inputField.GetAttribute("value").Length); // check that less then max chars number can be entered 
                    _inputField.Clear();
                });
            }
            else Assert.Fail("Input Max Chars Number isn't set");


        }
    }
}
