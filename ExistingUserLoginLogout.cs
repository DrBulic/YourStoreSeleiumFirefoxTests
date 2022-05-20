using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Xunit;
using System;
using System.Collections.ObjectModel;

namespace YourStorSeleniumFirefoxTests
{

    public class ExistingUser
    {
       

        [Fact]
        public void LoginLogout()
        {

            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("https://demo.opencart.com/");

                DemoHelper.Pause(1000);


                IWebElement topLinks = driver.FindElement(By.Id("top-links"));

                IWebElement pullRight = driver.FindElement(By.ClassName("pull-right"));

               // IWebElement topLinks3 = driver.FindElement(By.ClassName("dropdown-toggle"));


                ReadOnlyCollection<IWebElement> dropdownToggles = driver.FindElements(By.ClassName("dropdown-toggle"));

                //Click Accounts
                dropdownToggles[1].Click();

                DemoHelper.Pause(2000);

                Assert.Equal("Your Store", driver.Title);



                IWebElement dropDownMenuRight = driver.FindElement(By.ClassName("dropdown-menu-right"));

                ReadOnlyCollection<IWebElement> dropDownListElements = dropDownMenuRight.FindElements(By.TagName("li"));


                //Click Login from drop down menu
                dropDownListElements[1].Click();

                DemoHelper.Pause(2000);

                Assert.Equal("Account Login", driver.Title);


                ReadOnlyCollection<IWebElement> wellElements = driver.FindElements(By.ClassName("well"));

                /// go to Returning Customer
                ReadOnlyCollection<IWebElement> formControls = wellElements[1].FindElements(By.ClassName("form-control"));

                formControls[0].SendKeys("ivo.ivic@gmail.com");

                formControls[1].SendKeys("Test123");

                DemoHelper.Pause(2000);

                //Click Login Button
                wellElements[1].FindElement(By.ClassName("btn-primary")).Click();



                DemoHelper.Pause(4000);

             
                Assert.Equal("My Account", driver.Title);

                 topLinks = driver.FindElement(By.Id("top-links"));

                 pullRight = driver.FindElement(By.ClassName("pull-right"));

                // IWebElement topLinks3 = driver.FindElement(By.ClassName("dropdown-toggle"));


                 dropdownToggles = driver.FindElements(By.ClassName("dropdown-toggle"));


                //Click Accounts
                dropdownToggles[1].Click();

                DemoHelper.Pause();
                dropDownMenuRight = driver.FindElement(By.ClassName("dropdown-menu-right"));




                 dropDownListElements = dropDownMenuRight.FindElements(By.TagName("li"));


                //click logout form drop down list
                dropDownListElements[4].Click();

                Assert.Equal("Account Logout", driver.Title);

                DemoHelper.Pause(4000);


            }
            
          
        }

    }
}


