using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.Pages
{
    public class homePage
    {
        public void navigateToTMPage(IWebDriver driver)
        {
            //Navigate to Time and Material Page

            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/a"));
            administration.Click();

            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a", 10);

            IWebElement timeAndMaterials = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a"));
            timeAndMaterials.Click();
            Thread.Sleep(2000);
        }
    }
}
