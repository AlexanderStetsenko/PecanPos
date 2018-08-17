using NUnit.Framework;
using OpenQA.Selenium;
using PecanTest.Framework.ScreenObjects;
using System;
using System.Linq;

namespace PecanTest.Framework.Elements
{
    public class Field : Element
    {
        public Field(string name, By path) : base(name, path)
        {
        }

        public Field(string name, By path, Element parent) : base(name, path, parent)
        {
        }

        public IWebElement Clear(){
            GetWebElement().Clear();
            return GetWebElement();
        }

        public void ClearAndSendKeysToInput(String inputString)
        {
            var inputField = driver.FindElement(path);
            if (inputField.Displayed && inputField.Enabled)
            {
                inputField.Clear();
                inputField.SendKeys(inputString);
            }
            Assert.AreEqual(inputString, inputField.GetAttribute("value"));
        } //Fill Input with set String and check that string was entered
        public string SendKeysNum(int charsNumber) // Fills field by specified number of Number characters
        {
            Random random = new Random();
            string _chars = "0123456789";
            String enteredString = new string(Enumerable.Repeat(_chars, charsNumber).Select(s => s[random.Next(s.Length)]).ToArray());
            driver.FindElement(path).SendKeys(enteredString);
            return enteredString;
        }
        public string SendKeysNegativeNum(int charsNumber) // Fills field by specified number of negative Number characters and return entered string
        {
            Random random = new Random();
            string _chars = "0123456789";
            String enteredString = "-" + new string(Enumerable.Repeat(_chars, charsNumber).Select(s => s[random.Next(s.Length)]).ToArray());
            driver.FindElement(path).SendKeys(enteredString);
            return enteredString;
        }
        public string SendKeysAlphabetic(int charsNumber) // Fills field by specified number of negative Number characters and return entered string
        {
            Random random = new Random();
            string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String enteredString = "-" + new string(Enumerable.Repeat(_chars, charsNumber).Select(s => s[random.Next(s.Length)]).ToArray());
            GetWebElement().SendKeys(enteredString);
            return enteredString;
        }
        public string SendKeysToInput(int charsNumber) // Fills field by specified number of randim characters and return entered string
        {
            Random random = new Random();
            string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            String enteredString = new string(Enumerable.Repeat(_chars, charsNumber).Select(s => s[random.Next(s.Length)]).ToArray());
            driver.FindElement(path).SendKeys(enteredString);
            return enteredString;
        }


    }
}