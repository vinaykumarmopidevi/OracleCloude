using NUnit.Framework;
using System;
using Helpers.TestHelpers;
using Helpers.TestHelpers.BaseClasses;
using Helpers.TestHelpers.Configuration;
using Helpers.TestHelpers.TestBaseUtility;
using OpenQA.Selenium;

namespace SeleniumTests.Benefits
{
    [SetUpFixture]
    public class SetupFixture
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            IWebDriver driver = Browser.webDriver;

            if (driver == null)
            {
                InvokeForm.FormInvoke();
                
            }
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            IWebDriver driver = Browser.webDriver;

            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}