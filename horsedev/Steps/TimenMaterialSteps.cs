using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace horsedev.Steps
{
    [Binding]
    public class TimenMaterialSteps
    {
        IWebDriver driver;
        [Given(@"I am already logged in to the Horse env")]
        public void GivenIAmAlreadyLoggedInToTheHorseEnv()
        {
            driver = new ChromeDriver();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginSuccess();
        }
        
        [Given(@"I clicked admin n time and material")]
        public void GivenIClickedAdminNTimeAndMaterial()
        {
            HomePage h = new HomePage(driver);
            h.ClickAdministration();
            h.ClickTimenMaterials();
        }

        TimenMaterialPage timenMaterialPage;
        [When(@"I click on create new button and I entered valid data")]
        public void WhenIClickOnCreateNewButtonAndIEnteredValidData()
        {
            timenMaterialPage = new TimenMaterialPage(driver);
            timenMaterialPage.CreateNewRecord();
            
        }

               
        [Then(@"I validated that the record exists")]
        public void ThenIValidatedThatTheRecordExists()
        {
            timenMaterialPage.ValidateTheRedordCreated();
        }
    }
}
