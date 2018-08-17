using NUnit.Framework;
using OpenQA.Selenium;
using PecanTest.Framework.ScreenObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PecanTest.Framework.Elements
{
    public class Form : Element
    {
        string header;

        public Form(string name, By path) : base(name, path)
        {
        }
        public Form(string name, By path, Element parent) : base(name, path, parent)
        {
        }


        public void CheckThatFormOpen(string actualHeader)
        {
            Assert.AreEqual(this.header, actualHeader);
        }
        public void SubmitForm() { }
        public void CancelChanges() { }
        
    }
}
