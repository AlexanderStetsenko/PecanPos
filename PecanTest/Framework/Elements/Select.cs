using NUnit.Framework;
using OpenQA.Selenium;
using PecanTest.Framework.ScreenObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PecanTest.Framework.Elements
{
    public class Select : Element
    {
        public Field input;
        public Button arrow;
        public SelectDropDown dropdown;

        public Select(string name, By path) : base(name, path)
        {
        }
        public Select(string name, By path, Element parent) : base(name, path, parent)
        {
        }
        protected override Element InitWebElements()
        {
            input = new Field("Select input field", By.XPath("//input"));
            arrow = new Button("Select Arrow", By.CssSelector(".app-select-arrow"), this);
            dropdown = new SelectDropDown("Security Dropdown", By.XPath("//div[contains(@class, 'select-options')] "), this);
            return this;
        }
    }

    public class SelectDropDown : Option
    {
        public Option option;
        public SelectDropDown(string name, By path) : base(name, path)
        {
            this.name = name;
            this.path = path;
        }
        public SelectDropDown(string name, By path, Element parent) : base(name, path, parent)
        {
            this.name = name;
            this.path = path;
            this.parent = parent;
            InitWebElements();
        }

        public void SelectOption(String optionName) {
            var options = driver.FindElements(option.path);
            foreach(IWebElement _currentOption in options)
            {
                var _optionName = _currentOption.Text;
                if (_optionName == optionName)
                {
                    _currentOption.Click();
                    return;
                }
            }
        }
        protected override Element InitWebElements()
        {
            option = new Option("Option", By.XPath("//app-option"), this);
            return this;
        }


    }
}
