using OpenQA.Selenium;
using PecanTest.Framework.Elements;

namespace PecanTest.Framework.ScreenObjects.BackOffice.EmployeeSetup
{
    public class EmployeeSetupTab : Tab
    {
        public Button employeeJobTitleButton;
        public Button employeeListButton;
        public EmployeeJobTitleForm employeeJobTitleForm;

        public EmployeeSetupTab(string name, By path, Element parent) : base(name, path, parent)
        {
        }

        public override Element InitWebElements()
        {
            employeeJobTitleButton = new Button("Employee Job Title", By.XPath("//button[span='Employee Job Titles']"), this);
            employeeListButton = new Button("Employee Job Title", By.XPath("//button[span='Employee List']"), this);
            employeeJobTitleForm = new EmployeeJobTitleForm("Employee Job Title", By.XPath("//app-job-title-edit/div"));
            return this;
        }

    }
}