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
    public class Option : Element
    {

        public String Label { get; set; }

        public Option(string name, By path) : base(name, path)
        {
        }
        public Option(By path, Element parent) : base(path, parent)
        {
        }
        public Option(string name, By path, Element parent) : base(name, path, parent)
        {
        }




        public List<Option> GetOptionWebElementsList(Element parent, Option option)
        {
            var parentWeb = parent.GetWebElement();
            ReadOnlyCollection<IWebElement> _optionsWebElements = parentWeb.FindElements(path);
            List<Option> _options = new List<Option>();
            foreach (IWebElement _optionWebElement in _optionsWebElements)
            {
                var _xPath = By.XPath(GetAbsoluteXPath(_optionWebElement));
                var _option = new Option(_xPath, this);
                _option.Label = _optionWebElement.FindElement(_option.path).Text;
                _options.Add(_option);

            }
            return _options;

        } //Get all Options which availabele in Radio Button section


    }
}
