
using OpenQA.Selenium;

namespace PecanTest.Framework.ScreenObjects
{
    public class Screen : Element
    {
        public Screen(string name, By path) : base(name, path)
        {
        }

        public Screen(string name, By path, Element parent) : base(name, path, parent)
        {
        }


    }
}