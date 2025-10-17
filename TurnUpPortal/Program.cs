using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V138.Page;

public class Program
{
    private static void Main(string[] args)
    {
        //open chrome browser
        ChromeOptions options = new ChromeOptions();
        options.AddUserProfilePreference("profile.password_manager_leak_detection", false);
        IWebDriver driver = new ChromeDriver(options);

        //launch TurnUp portal and maximize window
        driver.Navigate().GoToUrl("http://horse.industryconnect.io");
        driver.Manage().Window.Maximize();
        Thread.Sleep(5000);

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

        //checking if the user logged in successfully

        IWebElement nameText = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        if (nameText.Text == "Hello hari!")
        {

            Console.WriteLine("User logged in successfully");
        }
        else
        {
            Console.WriteLine("User has not logged in. Test Failed");
        }


        //create test scripts for time and materials module

        //Navigate to Time and Material Page

        IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/a"));
        administration.Click();
        Thread.Sleep(2000);
        IWebElement timeAndMaterials = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a"));
        timeAndMaterials.Click();
        Thread.Sleep(2000);

        //Click on create New Button

        IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        createNew.Click();
        Thread.Sleep(2000);

        //Select Time from options

        IWebElement dropdownArrow = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        dropdownArrow.Click();
        Thread.Sleep(2000);
        IWebElement time = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
        time.Click();
        Thread.Sleep(2000);

        //Type code into Textbox

        IWebElement code = driver.FindElement(By.Id("Code"));
        code.SendKeys("TA Programme");
        Thread.Sleep(2000);

        // Type description 

        IWebElement description = driver.FindElement(By.Id("Description"));
        description.SendKeys("This is a description");
        Thread.Sleep(2000);

        // Type price
        IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        priceTagOverlap.Click();
        IWebElement price = driver.FindElement(By.Id("Price"));
        price.SendKeys("15");
        Thread.Sleep(2000);

        //Click on save button

        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();
        Thread.Sleep(2000);

        //check if the record is there at the last page

        IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        Thread.Sleep(5000);
        lastPage.Click();
        IWebElement lastColumn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

        if (lastColumn.Text == "TA Programme")
        {
            Console.WriteLine("Time record created successfully");
        }
        else
        {
            Console.WriteLine("Failed to create Time record");
        }
    }
}