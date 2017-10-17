using NUnit.Framework;
using System;
using TestFrameworkTutorial.BaseClasses;

namespace Tests.Scenarios
{
    [SetUpFixture]
    public class TestsSetupClass
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            HomePage h=new HomePage();
            h.Login(Configuration.ConfigurationManager.AppSettings["Username"]);
            h.Password(Configuration.ConfigurationManager.AppSettings["Password"]);
            h.LoginButton();

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
             Browser.Close();
        }
    }
}