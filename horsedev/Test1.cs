using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace horsedev
{
    [Parallelizable(ParallelScope.All)]
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

            TimenMaterialPage timenMaterialPage = new TimenMaterialPage(driver);
            timenMaterialPage.CreateNewRecord();
            timenMaterialPage.ValidateTheRedordCreated();
        }

        [Test]
        public void EditNValidateTM()
        {
            HomePage h = new HomePage(driver);
            h.ClickAdministration();
            h.ClickTimenMaterials();

            TimenMaterialPage timenMaterialPage = new TimenMaterialPage(driver);
            //edit the material
            //validat the material
        }

        [Test]
        public void DeletenValidate()
        {
            HomePage h = new HomePage(driver);
            h.ClickAdministration();
            h.ClickTimenMaterials();

            TimenMaterialPage timenMaterialPage = new TimenMaterialPage(driver);
            // delete a record
            // validate that the record doesn't exist in the table
        }



        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
