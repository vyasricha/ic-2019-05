using System;
using System.Threading;
using OpenQA.Selenium;

namespace horsedev
{
    internal class TimenMaterialPage
    {
        IWebDriver driver;

        public TimenMaterialPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement CreateNewBtn => driver.FindElement(By.XPath("//a[@href='/TimeMaterial/Create']"));
        IWebElement CodeTxt => driver.FindElement(By.XPath("//input[@id='Code']"));
        IWebElement DescText => driver.FindElement(By.XPath("//input[@id='Description']"));
        IWebElement SaveBtn => driver.FindElement(By.XPath("//input[@id='SaveButton']"));

        internal void CreateNewRecord()
        {
            // logic to create a new record
            CreateNewBtn.Click();
            CodeTxt.SendKeys("Somecode");
            DescText.SendKeys("SomeDesc");
            SaveBtn.Click();
        }

        IWebElement nextPagebtn => driver.FindElement(By.XPath("//span[contains(.,'Go to the next page')]"));

        internal void ValidateTheRedordCreated()
        {
            //implement explicit - assignment
            Thread.Sleep(3000); // implicit wait

            try {
                // to iterate between pages
                while (true)
                {
                    //to iterate with in 10 records on the screen
                    for (var i = 1; i <= 10; i++)
                    {
                        var codeText = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]")).Text;
                        Console.WriteLine(codeText);
                        if (codeText == "ghhghdasdhgg")
                        {
                            Console.WriteLine("Test Passed");
                            return;
                        }
                    }
                    //click next page
                    nextPagebtn.Click();
                }
            }
            catch (Exception) {
                  Console.WriteLine("Test Failed");
            }


        }
    }
}