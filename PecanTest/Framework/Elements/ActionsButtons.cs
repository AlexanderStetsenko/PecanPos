using OpenQA.Selenium;
using PecanTest.Framework.ScreenObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PecanTest.Framework.Elements
{
    public class ActionsButtons : Element

    {
        public Button saveButton;
        public Button doneButton;
        public Button cancelButton;

        public ActionsButtons(String name, By path) : base(name, path)
        {
        }
        public ActionsButtons(String name, By path, Element parent) : base(name, path, parent)
        {
        }

        protected override Element InitWebElements()
        {
            saveButton = new Button("Save Button", By.XPath(".//app-footer-action-buttons/button[span='Save']"), this);
            doneButton = new Button("Done Button", By.XPath(".//app-footer-action-buttons/button[span='Done']"), this);
            cancelButton = new Button("Cancel Button", By.XPath(".//app-footer-action-buttons/button[span='Cancel']"), this);
            return this;
        }

    }
}
