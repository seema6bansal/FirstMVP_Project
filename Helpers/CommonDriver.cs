using MVPproject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPproject.Helpers
{
    class CommonDriver
    {
        //Initialize the driver
        public IWebDriver driver { set; get;}


        [OneTimeSetUp]
        public void TestSetup()
        {
            //Define driver
           driver = new ChromeDriver();

            //Login page object
            LoginPage loginobj = new LoginPage();
            loginobj.LoginSteps(driver);

            //Home Page object
            HomePage homeobj = new HomePage();
            homeobj.NavigateToTMPage(driver);
        }

        [OneTimeTearDown]
        public void TestTearDown()
        {

            driver.Quit();
        }

    }
}
