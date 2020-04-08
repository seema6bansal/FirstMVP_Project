using MVPproject.Helpers;
using MVPproject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace MVPproject
{
        class Program
       {
        static void Main(string[] args)
        {
                       
         }

        //[SetUp]
        //public void TestSetup()
        //{
        //    // Define driver
        //    CommonDriver.driver = new ChromeDriver();

        ////Login page object
        //LoginPage loginobj = new LoginPage();
        //loginobj.LoginSteps(CommonDriver.driver);

        //    // Home Page object
        //    HomePage homeobj = new HomePage();
        //homeobj.NavigateToTMPage(CommonDriver.driver);

        //}

    //[Test]
    //    public void CreateTMTest()
    //    {
    //        //TM page object
    //        TMPage tmobj = new TMPage();
    //        tmobj.CreateTM(CommonDriver.driver);
    //    }
    //    [Test]
    //    public void EditTMTest()
    //    {
    //        TMPage tmobj = new TMPage();
    //        tmobj.EditTM(CommonDriver.driver);

    //    }

    //    [Test]
    //    public void DeleteTMTest()
    //    {
    //        TMPage tmobj = new TMPage();
    //        tmobj.DeleteTM(CommonDriver.driver);
    //    }

    //    [TearDown]
    //    public void TestTearDown()
    //    {

    //        CommonDriver.driver.Quit();
    //    }
       }

    [TestFixture, Description("Collection of tests for Time & Material page")]
 //   [Parallelizable]
    class TimeMaterialTestSuite : CommonDriver

    {
        
        [Test, Description("Validate new Create TM with valid data")]
        public void CreateTMTest()
        {
            //TM page object
            TMPage tmobj = new TMPage();
            tmobj.CreateTM(driver);
        }

        [Test, Description("Validate Edit TM with valid data")]
        public void EditTMTest()
        {
            TMPage tmobj = new TMPage();
            tmobj.EditTM(driver);

        }

        [Test, Description("Validate Delete TM with valid data")]
        public void DeleteTMTest()
        {
            TMPage tmobj = new TMPage();
            tmobj.DeleteTM(driver);
        }

    }

    [TestFixture, Description("Collection of tests for Customer page")]
//    [Parallelizable]
    class CustomerTestSuite : CommonDriver
    {
        
        [Test, Description("Validate Create new customer with valid data")]
        public void CreateCustomerTest()
        {
            //Customer page object
            CustomerPage cusobj = new CustomerPage(); 
            cusobj.CreateCustomer(driver);
        }

        [Test, Description("Validate Edit customer with valid data")]
        public void EditCustomerTest()
        {
            CustomerPage cusobj = new CustomerPage();
            cusobj.EditCustomer(driver);

        }

        [Test, Description("Validate Delete customer with valid data")]
        public void DeleteCustomerTest()
        {
            CustomerPage cusobj = new CustomerPage();
            cusobj.DeleteCustomer(driver);
        }

    }
}

