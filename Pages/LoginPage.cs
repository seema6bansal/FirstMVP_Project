using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPproject.Pages
{
    class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
           
            //Enter URL
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //Maximize the browser
            driver.Manage().Window.Maximize();

            //Find username textbox and enter username
            driver.FindElement(By.Id("UserName")).SendKeys("hari");

            //Find password textbox and enter password
            driver.FindElement(By.Id("Password")).SendKeys("123123");

            //Find login button and click on login button
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();


        }
    }
}
