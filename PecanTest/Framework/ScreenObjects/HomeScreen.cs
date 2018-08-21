using OpenQA.Selenium;


namespace PecanTest.Framework.ScreenObjects
{
    public class HomeScreen : Screen
    {
        public Button backOfficeButton;

        public HomeScreen(string name, By path) : base(name, path)
        {
            this.name = name;
            this.path = path;
        }

        protected override Element InitWebElements() {
            backOfficeButton = new Button(name: "back Office Button", 
                                          path: By.XPath("//app-home-button/a[span='Back Office']"), 
                                          this);
            return this;
        }

    }
}
