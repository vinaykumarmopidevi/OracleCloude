using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;
using System;

namespace Helpers.TestHelpers
{
    public  class HomePage
    {
        private static IWebDriver driver;


        private static string Url = System.Configuration.ConfigurationManager.AppSettings["Website"];

        //private static string PageTitle = "Pluralsight -nv Hardcore Developer Training";

        private static string PageTitle = "Sign In";
        private static string NavigatorPageTitle = "Welcome";

        [FindsBy(How = How.Id,Using="userid")]
        private IWebElement logintext;
        

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordtext;

        public void Login(object p)
        {
            throw new NotImplementedException();
        }

        [FindsBy(How = How.Id, Using = "btnActive")]
        private IWebElement loginbutton;

        [FindsBy(How = How.LinkText, Using = "You have a new home page!")]
        private IWebElement NavigatorPageLink;
        
        [FindsBy(How = How.LinkText,Using="Features")]
        private IWebElement FeatureLink;

        [FindsBy(How = How.LinkText, Using = "Authors")]
        private IWebElement AuthorLink;

        [FindsBy(How = How.LinkText, Using = "Improve my abilities")]
        private IWebElement ImproveLink;

        [FindsBy(How = How.CssSelector, Using = "div.homepage-modal--individuals.overlay.black")]
        private IWebElement IndividualLink;

  
        public void GoTo()
        {
            Browser.Goto(Url);
            System.Threading.Thread.Sleep(5000);
            Browser.MaximizeBrowserPage();
        }

        public bool IsAt()
        {
            return Browser.Title == PageTitle;
        }

        public bool IsAtNavigatorPage()
        {
            return Browser.Title == NavigatorPageTitle;
        }

        public void SelectAuthorPage()
        {
            AuthorLink.Click();
        }

        public void Login(string Username)
        {
            //var userData = ExcelDataAccess.GetTestData(testName);
            System.Threading.Thread.Sleep(2000);
            logintext.SendKeys(Username);
        }

        public void Password(string Password)
        {
            //var userData = ExcelDataAccess.GetTestData(testName);
            System.Threading.Thread.Sleep(2000);
            passwordtext.SendKeys(Password);
        }

        public void LoginButton()
        {

            System.Threading.Thread.Sleep(5000);
            loginbutton.Click();
            System.Threading.Thread.Sleep(10000);
        }

        public void SelectFeature()
        {
            System.Threading.Thread.Sleep(5000);
            FeatureLink.Click();
         
        }

        //public bool IsAtNavigatorPage(string NavigatorLink)
        //{
        //    var authorPage = new AuthorPage();
        //    PageFactory.InitElements(Browser.Driver, authorPage);
        //    return authorPage.NavigatorLink == NavigatorLink;
        //}

        public void SelectAuthor(string authorName)
        {
            
            var author = Browser.Driver.FindElement(By.LinkText(authorName));
            author.Click();        
        }

        public void SelectPopup()
        {
            ImproveLink.Click();
            System.Threading.Thread.Sleep(5000);
        }

        public void SelectIndividualPopup()
        {
            IndividualLink.Click();
            System.Threading.Thread.Sleep(5000);
        }

       
    }
}