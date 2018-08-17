using OpenQA.Selenium;
using PecanTest.Framework.ScreenObjects.BackOffice;

namespace PecanTest.Framework.ScreenObjects
{
    public class PecanApp
    {
        public IWebDriver driver;
        public HomeScreen homeScreen;
        public BackOfficeScreen backOffice;

        public PecanApp(IWebDriver driver) {
            this.driver = driver;
            homeScreen = new HomeScreen("HomeScren", By.XPath("//main/app-home/div"));
            backOffice = new BackOfficeScreen("Back Offcie", By.XPath("//app-back-office"));
        }
        
    }
}
