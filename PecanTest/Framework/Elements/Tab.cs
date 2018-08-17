using OpenQA.Selenium;
using PecanTest.Framework.ScreenObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PecanTest.Framework.Elements
{
    public class Tab : Element
    {
        public Tab(string name, By path) : base(name, path)
        {
        }
        public Tab(string name, By path, Element parent) : base(name, path, parent)
        {
            this.name = name;
            this.path = path;
            this.parent = parent;
        }

        public void Select() {
            GetWebElement().Click();
        }


    }
}
