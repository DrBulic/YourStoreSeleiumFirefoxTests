using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Xunit;
using System;
using System.Collections.ObjectModel;

namespace YourStorSeleniumFirefoxTests
{

    public class RegisterUser
    {


        [Fact]
        public void Register()
        {

            using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("https://demo.opencart.com/");

                driver.Manage().Window.Maximize();

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


                //Click Register from drop down menu
                dropDownListElements[0].Click();

                DemoHelper.Pause(2000);

                Assert.Equal("Register Account", driver.Title);

                Random rnd = new Random();

                string s = rnd.Next().ToString();

                IWebElement firstName = driver.FindElement(By.Id("input-firstname"));

                firstName.SendKeys("Ivo");

                IWebElement lastName = driver.FindElement(By.Id("input-lastname"));

                lastName.SendKeys("Ivo");

                IWebElement email = driver.FindElement(By.Id("input-email"));

                email.SendKeys("ivo.ivic" + s + "@gmail.com");

                IWebElement telephone = driver.FindElement(By.Id("input-telephone"));

                telephone.SendKeys("0911234567");

                IWebElement password = driver.FindElement(By.Id("input-password"));

                password.SendKeys("Test123");

                IWebElement confirm = driver.FindElement(By.Id("input-confirm"));

                confirm.SendKeys("Test123");

                IWebElement buttons = driver.FindElement(By.ClassName("buttons"));

                ReadOnlyCollection< IWebElement > inputs = buttons.FindElements(By.TagName("input"));

                // Click I Agree
                inputs[0].Click();

                DemoHelper.Pause();

                // Click Continue
                inputs[1].Click();



                DemoHelper.Pause(5000);


                Assert.Equal("Your Account Has Been Created!", driver.Title);





            }
        }
    }
}