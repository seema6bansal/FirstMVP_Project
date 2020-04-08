using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPproject.Pages
{
    class HomePage
    {
        public void ValidateLogin(IWebDriver driver)
        {
            //Validate if user had logged in
            Assert.That(driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")).Text, Is.EqualTo("Hello hari!"));
            
            //if (driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")).Text == "Hello hari!")
            //{
            //    Console.WriteLine("Logged in successfully, Testcase1 passed");
            //}
            //else
            //{
            //    Console.WriteLine("Logged in failed, Testcase1 failed");
            //}

        }          
        public void NavigateToTMPage(IWebDriver driver)
        {
            //Find Adiministration drop down and click
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]")).Click();

            //Find 'Time & Materials' and click 
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();


        }


    }
}
