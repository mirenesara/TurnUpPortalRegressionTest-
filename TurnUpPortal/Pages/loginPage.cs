using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortal.Pages
{
    public class loginPage
    {

        //Functions that allows users to login to turnUp Portal
        public void loginActions(IWebDriver driver)
        {
            //launch TurnUp portal and maximize window
            driver.Navigate().GoToUrl("http://horse.industryconnect.io");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);


            //explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UserName")));

            //Identify username textbox and enter valid username

            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

          


            //Identify password textbox and enter valid password

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            //Identify login button and click on it using XPath

            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(2000);

            IWebElement nameText = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            if (nameText.Text == "Hello hari!")
            {

                Console.WriteLine("User logged in successfully");
            }
            else
            {
                Console.WriteLine("User has not logged in. Test Failed");
            }
        }
    }
}
