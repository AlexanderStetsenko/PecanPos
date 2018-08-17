using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using PecanTest.Framework.DriverWrapper;
using PecanTest.Framework.ScreenObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PecanTest.Tests
{
    public class BaseTest
    {
        public BaseTest() {

        }

        private ChromeOptions options = new ChromeOptions();
        public PecanApp  app;

        [OneTimeSetUp]
        public void OneTimeSetUp() {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\Alex\node_modules\electron-chromedriver\bin");
            options.BinaryLocation = @"H:\Pecan\Pecan-POS\dist\win-unpacked\Pecan POS.exe";
            Element.driver = new ChromeDriver(service, options);
            app = new PecanApp(Element.driver);
        }

        [OneTimeTearDown]
        public void TurnDown()
        {
            Element.driver.Close();
        }

    }
}
