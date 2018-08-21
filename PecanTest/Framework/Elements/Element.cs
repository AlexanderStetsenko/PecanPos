using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PecanTest.Framework.ScreenObjects
{
    public class Element
    {
        public static ChromeDriver driver;
        public string name;
        public  By path;
        public Element parent;

        public Element(By path)
        {
            this.path = path;
        }
        public Element(By path, Element parent)
        {
            this.path = path;
            this.parent = parent;
        }
        public Element(string name, By path)
        {
            this.name = name;
            this.path = path;
            InitWebElements();
        }
        public Element(string name, By path, Element parent)
        {
            this.name = name;
            this.path = path;
            this.parent = parent;
            InitWebElements();
        }

        protected virtual Element InitWebElements()
        {
            return this;
        }
        public virtual IWebElement GetWebElement()
        {
            if (parent != null)
            {
                return driver.FindElement(parent.path).FindElement(path);
            }
            else return driver.FindElement(path);
        }
        protected String GetAbsoluteXPath(IWebElement element)
        {
            return (String)((IJavaScriptExecutor)driver).ExecuteScript(
                    "function absoluteXPath(element) {" +
                            "var comp, comps = [];" +
                            "var parent = null;" +
                            "var xpath = '';" +
                            "var getPos = function(element) {" +
                            "var position = 1, curNode;" +
                            "if (element.nodeType == Node.ATTRIBUTE_NODE) {" +
                            "return null;" +
                            "}" +
                            "for (curNode = element.previousSibling; curNode; curNode = curNode.previousSibling){ " +
                        "if (curNode.nodeName == element.nodeName) {" +
                        "++position;" +
                        "}" +
                        "}" +
                        "return position;" +
                        "};" +
                        "if (element instanceof Document) {" +
                        "return '/';" +
                        "}" +

                        "for (; element && !(element instanceof Document); element = element.nodeType == Node.ATTRIBUTE_NODE? element.ownerElement: element.parentNode) {" +
                        "comp = comps[comps.length] = {};" +
                        "switch (element.nodeType) {" +
                        "case Node.TEXT_NODE:" +
                        "comp.name = 'text()';" +
                        "break;" +
                        "case Node.ATTRIBUTE_NODE:" +
                        "comp.name = '@' + element.nodeName;" +
                        "break;" +
                        "case Node.PROCESSING_INSTRUCTION_NODE:" +
                        "comp.name = 'processing-instruction()';" +
                        "break;" +
                        "case Node.COMMENT_NODE:" +
                        "comp.name = 'comment()';" +
                        "break;" +
                        "case Node.ELEMENT_NODE:" +
                        "comp.name = element.nodeName;" +
                        "break;" +
                        "}" +
                        "comp.position = getPos(element);" +
                        "}" +

                        "for (var i = comps.length - 1; i >= 0; i--) {" +
                        "comp = comps[i];" +
                        "xpath += '/' + comp.name.toLowerCase();" +
                        "if (comp.position !== null) {" +
                        "xpath += '[' + comp.position + ']';" +
                        "}" +
                        "}" +

                        "return xpath;" +

                    "} return absoluteXPath(arguments[0]);", element);
        }

    }
}