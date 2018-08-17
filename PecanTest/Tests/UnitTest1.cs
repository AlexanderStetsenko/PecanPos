using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using PecanTest.Framework.ScreenObjects;

using System.Threading;

namespace PecanTest.Tests
{
    [TestFixture]
    [AllureNUnit]
    public class UnitTest1 : BaseTest
    {

        [Test(Description = "Test A")]
        [AllureTag("NUnit", "Debug")]
        [AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void TestMethod1()
        {
            app.homeScreen.backOfficeButton.Click();
            app.backOffice.employeeSetupTab.Select();
            app.backOffice.employeeSetupTab.employeeJobTitleButton.Click();
            app.backOffice.employeeSetupTab.employeeJobTitleForm.CheckThatFormOpen();
            app.backOffice.employeeSetupTab.employeeJobTitleForm.jobTitleName.CheckMaxChars();
            app.backOffice.employeeSetupTab.employeeJobTitleForm.jobTitleName.ClearAndSendKeysToInput("Privet ka dela?");
            app.backOffice.employeeSetupTab.employeeJobTitleForm.jobTitleName.ClearAndSendKeysToInput("Privet ka dela?");
            app.backOffice.employeeSetupTab.employeeJobTitleForm.actionButtons.doneButton.Click();
            app.backOffice.employeeSetupTab.employeeJobTitleForm.payRate.CheckThatPriceField();
            app.backOffice.employeeSetupTab.employeeJobTitleForm.securityLevel.arrow.Click();

            app.backOffice.employeeSetupTab.employeeJobTitleForm.securityLevel.dropdown.SelectOption("Level 1");
            app.backOffice.employeeSetupTab.employeeJobTitleForm.securityLevel.arrow.Click();

            app.backOffice.employeeSetupTab.employeeJobTitleForm.securityLevel.dropdown.SelectOption("Level 2");
            app.backOffice.employeeSetupTab.employeeJobTitleForm.securityLevel.arrow.Click();

            app.backOffice.employeeSetupTab.employeeJobTitleForm.securityLevel.dropdown.SelectOption("Level 3");
            app.backOffice.employeeSetupTab.employeeJobTitleForm.securityLevel.arrow.Click();

            app.backOffice.employeeSetupTab.employeeJobTitleForm.securityLevel.dropdown.SelectOption("Level 4");

            app.backOffice.employeeSetupTab.employeeJobTitleForm.hourlySalaried.Select("Salaried");

            app.backOffice.employeeSetupTab.employeeJobTitleForm.hourlySalaried.Select("Hourly");
            app.backOffice.employeeSetupTab.employeeJobTitleForm.hourlySalaried.Select("Salaried");

            app.backOffice.employeeSetupTab.employeeJobTitleForm.hourlySalaried.Select("Hourly");
            app.backOffice.employeeSetupTab.employeeJobTitleForm.hourlySalaried.Select("Salaried");

            app.backOffice.employeeSetupTab.employeeJobTitleForm.hourlySalaried.Select("Hourly");
        }




        [Test(Description = "Test B")]
        public void TestMethod2()
        {
            Thread.Sleep(5000);
            Element.driver.FindElement(By.XPath("//app-home-button/a[span='Back Office']")).Click();
            Thread.Sleep(2000);
            Element.driver.FindElement(By.XPath("//app-office-container/app-office-menu/nav/a[2]")).Click();
            Thread.Sleep(2000);
        }

    }
}
