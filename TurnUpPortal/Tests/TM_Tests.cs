using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal.Pages;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void SetUpSteps()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("profile.password_manager_leak_detection", false);
            driver = new ChromeDriver(options);

            loginPage loginpageObj = new loginPage();
            loginpageObj.loginActions(driver);

            homePage homePageObj = new homePage();
            homePageObj.navigateToTMPage(driver);

        }
        [Test]
        public void createTime_Test()
        {
            timeMaterialPage TMObj = new timeMaterialPage();
            TMObj.createTimeRecord(driver);
        }

        [Test]
        public void EditTime_Test()
        {

        }

        [Test]
        public void DeleteTime_Test()
        {

        }

        [TearDown]
        public void CloseTestRun()
        {

        }
        [TearDown]
        public void closeTestRun()
        {
            driver.Quit();
        }
    }
}
