using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
namespace MVPproject.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {

            //Test case for create new record on time & material page
            //-----------------------------------------------------------------------------

            //Find Create New button and click on 'Create New' button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            //Find TypeCode and and click 
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(2000);

            //Select 'Time' from type code dropdown
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();

            //Select 'Material' from type code drop down
            //driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']")).Click();
            
            //Find Code textbox and enter code
            driver.FindElement(By.Id("Code")).SendKeys("S12020");

            //Find description textbox and enter description
            driver.FindElement(By.Id("Description")).SendKeys("Test Records by S1 for Material");

            //Find price per unit textbox and enter the price
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='Price']")).SendKeys("20");
         

            //Find save button and click on the save button
            driver.FindElement(By.Id("SaveButton")).Click();

            Console.WriteLine("Record created sucessfully");

            int rowcount = driver.FindElements(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[1]")).Count;
            Console.WriteLine("Row count is :  " + rowcount);

            int colcount = driver.FindElements(By.XPath("//*[@id='tmsGrid']/div[2]/div/table/thead/tr/th")).Count;
            Console.WriteLine("Column count is :  " + colcount);

            // Navigate to last page
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();

            String totalrow = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/span[2]")).Text;
                        
            Console.WriteLine("Total rows are :" + totalrow);


            //Validate TM create

            //Option 1 for Assertion
            //Assert.That(driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[5]/td[1]")).Text, Is.EqualTo("S12020"));

            //Option 2 for Assertion
            //if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[5]/td[1]")).Text == "S12020")
            // {
            //    Console.WriteLine("TM created, Test passed");
            //    Assert.Pass();
            //}
            //else
            //{
            //    Console.WriteLine("TM not created, Test failed");
            //    Assert.Fail();
            // }

        }

        public void EditTM(IWebDriver driver)
        {
            //Test case for Edit functionality on 'Time & Material' page.
            //---------------------------------------------------------------------------------

            //Find Edit button and click on Edit button
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]"))).Click();


            //Find Code textbox and enter code
            IWebElement Codetxt = driver.FindElement(By.Id("Code"));
            Codetxt.Clear();
            Codetxt.SendKeys("S32021");

            //Find description textbox and enter description
            IWebElement Desctxt = driver.FindElement(By.Id("Description"));
            Desctxt.Clear();
            Desctxt.SendKeys("Test Records edited by S2");

            //Find price per unit textbox and enter the price
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='Price']")).Clear();

            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            IWebElement Pricetxt = driver.FindElement(By.XPath("//*[@id='Price']"));

            Pricetxt.SendKeys("25");

            //Find save button and click on the save button
            driver.FindElement(By.Id("SaveButton")).Click();

            Console.WriteLine("Record editted sucessfully");
        }

        public void DeleteTM(IWebDriver driver)
        {
            //Test case for delete functionality
            //...................................................................................

            //Find delete button and click on delete button

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement deletebtn = wait1.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[8]/td[5]/a[2]")));
           
            deletebtn.Click();

            //Alert message handing, accept the aler to delete the record
            IAlert alert = driver.SwitchTo().Alert();

            Thread.Sleep(2000);
            alert.Accept();

            Console.WriteLine("Record deleted sucessfully");

        }
    }
}
