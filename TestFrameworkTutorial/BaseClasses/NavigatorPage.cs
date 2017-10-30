using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using Helpers.TestHelpers;
using Helpers.TestHelpers;




namespace Helpers.TestHelpers.BaseClasses
{
    class NavigatorPage
    {

        [FindsBy(How = How.Id, Using = "pt1:commandLink1")]
        private IWebElement navigatorlink;

        private static string NavigatorPageTitle = "Welcome";

        public string NavigatorLink
        {
            get { return navigatorlink.Text; }
        }

        //public bool IsAtNavigatorPage(string NavigatorLink)
        //{
        //     var authorPage = new AuthorPage();
        //    PageFactory.InitElements(Browser.Driver, authorPage);
        //    return authorPage.NavigatorLink == NavigatorLink;
        //}

        public bool IsAtNavigatorPage()
        {
            return Browser.Title == NavigatorPageTitle;
        }
    }
}
