using System;
using OpenQA.Selenium;

namespace horsedev
{
    internal class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement adminTab => driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]"));

        internal void ClickAdministration()
        {
            adminTab.Click();
        }

        IWebElement timeMaterialTab => driver.FindElement(By.XPath("//a[@href='/TimeMaterial']"));
        internal void ClickTimenMaterials()
        {
            timeMaterialTab.Click();
        }
    }
}