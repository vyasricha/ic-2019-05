using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using horsedev.helpers;
using OpenQA.Selenium;

namespace horsedev
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage()
        {
           
        }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement username => driver.FindElement(By.Id("UserName"));
        IWebElement password => driver.FindElement(By.Id("Password"));
        IWebElement loginbtn => driver.FindElement(By.XPath("//input[@value='Log in']"));



        internal void LoginSuccess()
        {
            //driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            driver.Navigate().GoToUrl(ExcelLibHelpers.ReadData(2,"url"));

            //username.SendKeys("hari");
            username.SendKeys(ExcelLibHelpers.ReadData(2,"username"));

            //password.SendKeys("123123");
            password.SendKeys(ExcelLibHelpers.ReadData(2,"password"));

            loginbtn.Click();
        }

        internal void LoginFailure()
        {
            username.SendKeys("whole idea");
            driver.FindElement(By.Id("UserName")).SendKeys("wdfwf");
            driver.FindElement(By.Id("Password")).SendKeys("sfsdf");
            driver.FindElement(By.XPath("//input[@value='Log in']")).Click();
        }
    }
}
