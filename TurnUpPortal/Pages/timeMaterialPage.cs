using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal.Utilities;

namespace TurnUpPortal.Pages
{
    public class timeMaterialPage
    {
        public void createTimeRecord(IWebDriver driver)
        {

            //Exception Handling

            try
            {
                IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
                createNew.Click();
            }
            catch (Exception ex) { 
                Assert.Fail("Create new button hasn't been identified");
            }
            
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

            Wait.WaitToBeClickable(driver, "Id", "SaveButton", 3);
            //Click on save button

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
           

            //check if the record is there at the last page

            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            Thread.Sleep(5000);
            lastPage.Click();
            IWebElement lastColumn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            //NUnit Assertions

            Assert.That(lastColumn.Text == "TA Programme", "Failed to create Time record");

            //if (lastColumn.Text == "TA Programme")
            //{
            //    Assert.Pass("Time record created successfully");
            //}
            //else
            //{
            //    Assert.Fail ("Failed to create Time record");
            //}
        }

        public void editTimeRecord()
        {

        }

        public void deleteTimeRecord()
        {

        }

       
    }

}
