using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V138.Page;
using OpenQA.Selenium.Support.UI;
using TurnUpPortal.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        //open chrome browser
        ChromeOptions options = new ChromeOptions();
        options.AddUserProfilePreference("profile.password_manager_leak_detection", false);
        IWebDriver driver = new ChromeDriver(options);

        /*implicit wait
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10);
        */

        //page object implementation

        loginPage loginpageObj = new loginPage();
        loginpageObj.loginActions(driver);

        homePage homePageObj= new homePage();
        homePageObj.navigateToTMPage(driver);

        timeMaterialPage TMObj=new timeMaterialPage();
        TMObj.createTimeRecord(driver); 
    }
}