using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace horsedev
{
    public class Test1
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginSuccess();            
        }

        [Test]
        public void AddnValidateTM()
        {
            HomePage h = new HomePage(driver);
            h.ClickAdministration();
            h.ClickTimenMaterials();


        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
