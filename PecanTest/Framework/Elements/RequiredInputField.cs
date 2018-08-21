using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using PecanTest.Framework.Interfaces;
using PecanTest.Framework.ScreenObjects;

namespace PecanTest.Framework.Elements
{
    public class RequiredInputField : InputField, IRequired
    {
        public RequiredInputField(string name, By path, int maxChar) : base(name, path, maxChar)
        {
        }
        public RequiredInputField(string name, By path, Element parent, int maxChar) : base(name, path, parent, maxChar)
        {
        }


        public void CheckThatReuired()
        {
            System.Console.WriteLine("Check Required method");
        }

    }
}
