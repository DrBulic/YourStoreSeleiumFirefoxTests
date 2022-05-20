using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Xunit;
using System;
using System.Collections.ObjectModel;

namespace YourStorSeleniumFirefoxTests
{

    public class ExistingUserSearch
    {


        [Fact]
        public void Search()
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

                //User is logged in



                // Search for "HP"
                IWebElement pullRight1 = driver.FindElement(By.ClassName("container"));

                IWebElement form = driver.FindElement(By.ClassName("form-control"));

                form.SendKeys("HP");

                DemoHelper.Pause(2000);


                //Click search button
                IWebElement searchColumn = driver.FindElement(By.ClassName("col-sm-5"));


                searchColumn.FindElement(By.ClassName("btn")).Click();

                DemoHelper.Pause(2000);



                //Open Categories and select Printers

                IWebElement column3 = driver.FindElement(By.ClassName("col-sm-3"));

                IWebElement form1 = driver.FindElement(By.ClassName("form-control"));


                ReadOnlyCollection<IWebElement> options = driver.FindElements(By.TagName("option"));

                options[12].Click();

                DemoHelper.Pause(2000);

                // Click Search button

                IWebElement buttonSearch = driver.FindElement(By.Id("button-search"));

                buttonSearch.Click();

                DemoHelper.Pause(4000);






                //search for logout inder account drop down menu
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


