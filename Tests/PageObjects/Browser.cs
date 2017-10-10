using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using Tests.TestCases;

namespace Tests.PageObjects
{
    public static class Browser
    {
        static string browser_name = Configuration.ConfigurationManager.AppSettings["Browser"];

        //CHROME
        static IWebDriver webDriver = BaseTest.openBrowser(browser_name);

        //firefox
        //  static IWebDriver webDriver = new FirefoxDriver(@"C:\temp\");
        //IE
        //  static IWebDriver webDriver = new InternetExplorerDriver(@"C:\temp\);
        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; } 
        }

        public static object BasTest { get; private set; }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
           webDriver.Close();
        }

        public static void MaximizeBrowserPage()
        {
            webDriver.Manage().Window.Maximize();
        }

        internal static string GetWindowHandle()
        {
            throw new NotImplementedException();
        }
    }
}
//public static IWebDriver WebDriver { get => webDriver; set => webDriver = value; }
   // }
//public static IWebDriver WebDriver { get => webDriver; set => webDriver = value; }
  //  }
