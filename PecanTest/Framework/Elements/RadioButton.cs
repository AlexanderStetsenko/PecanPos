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
    public class RadioButtonSection : Option
    {
        private Option radioButtonOption;
        public RadioButtonSection(string name, By path) : base(name, path)
        {
        }
        public RadioButtonSection(string name, By path, Element parent) : base(name, path, parent)
        {
        }

        public void Select(String optionName) {

            List<Option> _options = radioButtonOption.GetOptionWebElementsList(this, radioButtonOption);
            driver.FindElement(_options.First(o => o.Label == optionName).path).Click();
        }
        protected override Element InitWebElements()
        {
            radioButtonOption = new Option(By.XPath(".//mat-radio-button"), this);
            return this;
        }

        //private List<Option> GetOptionWebElementsList()
        //{
        //    var _radioButtonSectionWeb = GetWebElement();
        //    ReadOnlyCollection<IWebElement> _optionsWebElements = _radioButtonSectionWeb.FindElements(radioButtonOption.path);
        //    List<Option> _options = new List<Option>();
        //    foreach (IWebElement _optionWebElement in _optionsWebElements)
        //    {
        //        var _xPath = By.XPath(GetAbsoluteXPath(_optionWebElement));
        //        var _option = new Option(_xPath, this);
        //        _option.Label = _optionWebElement.FindElement(By.XPath(".//label/div[@class='mat-radio-label-content']")).Text;
        //        _options.Add(_option);

        //    }
        //    return _options;

        //} //Get all Options which availabele in Radio Button section

    }
}
//mat-radio-button[1]/