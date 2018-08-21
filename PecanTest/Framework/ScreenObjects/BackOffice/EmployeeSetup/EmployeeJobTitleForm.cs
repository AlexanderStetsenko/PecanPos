using NUnit.Framework;
using OpenQA.Selenium;
using PecanTest.Framework.Elements;


namespace PecanTest.Framework.ScreenObjects.BackOffice.EmployeeSetup
{
    public class EmployeeJobTitleForm : Form
    {
        public Title title;
        public RequiredInputField jobTitleName;
        public Select securityLevel;
        public RadioButtonSection hourlySalaried;
        public PriceField payRate;
        public RadioButtonSection activeInactive;
        //public ActiveInactiveList activeInactiveList;
        //public Button addNewEntity;
        public ActionsButtons actionButtons;


        public EmployeeJobTitleForm(string name, By path) : base(name, path)
        {
            this.name = name;
            this.path = path;
        }
        public EmployeeJobTitleForm(string name, By path, Element parent) : base(name, path, parent)
        {
            this.name = name;
            this.path = path;
            this.parent = parent;
        }

        protected override Element InitWebElements()
        {
            title = new Title("Job Titles", By.CssSelector("h2"));
            jobTitleName = new RequiredInputField("Job Titles Name", By.XPath("//div/app-input-form-input/input"), 50);
            securityLevel = new Select("Security Level", By.XPath(".//app-input-form-input[app-select]"), this);
            actionButtons = new ActionsButtons("Actions ", By.XPath("//app-footer-action-buttons"), this);
            payRate = new PriceField("Pay Rate", By.XPath(".//app-input-number/input"), this, 8);
            hourlySalaried = new RadioButtonSection("Hourly Salaried", By.XPath("//mat-radio-group[1]"), this);
            return this;
        }

        public void CheckThatFormOpen()
        {
            var actuaTitlte = driver.FindElement(title.path).Text;
            Assert.AreEqual(actuaTitlte, title.name);
        }
    }
}
