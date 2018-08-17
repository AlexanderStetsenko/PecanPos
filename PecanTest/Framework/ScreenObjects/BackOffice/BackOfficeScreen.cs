using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PecanTest.Framework.Elements;
using PecanTest.Framework.ScreenObjects.BackOffice.EmployeeSetup;

namespace PecanTest.Framework.ScreenObjects.BackOffice
{
    public class BackOfficeScreen : Screen
    {
        public Tab generalTab;
        public Tab menuSetupTab;
        public Tab securitySettingsTab;
        public EmployeeSetupTab employeeSetupTab;

        public BackOfficeScreen(string name, By path) : base(name, path)
        {
            this.name = name;
            this.path = path;
        }

        public override Element InitWebElements()
        {
            generalTab = new Tab("General Tab", By.XPath("//app-office-menu/nav/a[@routerlink='/office/general']"), this);
            menuSetupTab = new Tab("Menu Setup Tab", By.XPath("//app-office-menu/nav/a[@routerlink='/office/menu']"));
            securitySettingsTab = new Tab("Security Seting Tab", By.XPath("//app-office-menu/nav/a[@routerlink='/office/security']"));
            employeeSetupTab = new EmployeeSetupTab("Employee Job Tile Tab", By.XPath("//app-office-menu/nav/a[@routerlink='/office/employee']"), this);
            return this;
        }
    }
}
