using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tests.PageObjects
{
    public class AuthorPage
    {
        [FindsBy(How = How.CssSelector, Using = "div.author-content h2")]
        private IWebElement authorName;

        [FindsBy(How = How.Id, Using = "pt1:commandLink1")]
        private IWebElement navigatorlink;


        public string AuthorName
        {
            get { return authorName.Text; }
        }

        public string NavigatorLink
        {
            get { return navigatorlink.Text; }
        }

    }
}