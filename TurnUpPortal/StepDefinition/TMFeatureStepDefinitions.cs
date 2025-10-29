using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using System;
using TurnUpPortal.Pages;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.StepDefinition
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given("I logged into TurnUp Portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            
            driver = new ChromeDriver();

            loginPage loginpageObj = new loginPage();
            loginpageObj.loginActions(driver);
        }

        [When("I navigate to Time and Material Page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            homePage homePageObj = new homePage();
            homePageObj.navigateToTMPage(driver);
        }

        [When("I create a time record")]
        public void WhenICreateATimeRecord()
        {
            timeMaterialPage TMObj = new timeMaterialPage();
            TMObj.createTimeRecord(driver);
        }

        [Then("the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
           timeMaterialPage tm=new timeMaterialPage();

            String code = tm.GetCode(driver);
            String desc=tm.GetDesc(driver);
            String price=tm.GetPrice(driver);


            Assert.That(code == "TA Programme", "Actual and expected code do not match");
            Assert.That(desc == "This is a description", "Actual and expected description do not match");
            Assert.That(price == "12", "Actual and expected price do not match");
        }

        [When("I update the {string} on an existing record")]
        public void WhenIUpdateTheOnAnExistingRecord(string code)
        {
            
        }

        [Then("the record should have the updated {string}")]
        public void ThenTheRecordShouldHaveTheUpdated(string code)
        {
            
        }

    }
}
