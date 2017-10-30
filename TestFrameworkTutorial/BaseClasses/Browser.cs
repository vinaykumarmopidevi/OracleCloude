using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using Helpers.TestHelpers;
using Helpers.TestHelpers.Configuration;
using Helpers.TestHelpers.TestBaseUtility;
using NPOI.HSSF.Record;

namespace Helpers.TestHelpers.BaseClasses
{
    public static class Browser
    {
        private static log4net.ILog Log = CommonBase.Log;
        
        public static IWebDriver webDriver = null;

        public static bool gridRun = false;

        public static IWebDriver GetDriver(string bName)
        {
            string _project_path = getFilePath();
            
            if (!gridRun)
            {
                if (bName.Equals("Mozilla"))
                {
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(_project_path + @"TestFrameworkTutorial\Resources\geckodriver\", "geckodriver.exe");
                    //service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                    webDriver = new FirefoxDriver(service);
                    webDriver.Manage().Window.Size = new Size(1024, 768);

                }

                if (bName.Equals("Chrome"))
                {
                    
                    webDriver = new ChromeDriver(_project_path + @"TestFrameworkTutorial\Resources\chromedriver\");
                }

                if (bName.Equals("InternetExplorer"))
                {

                    webDriver = new InternetExplorerDriver(_project_path + @"TestFrameworkTutorial\Resources\IEDriverServer\");

                }


                webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
                webDriver.Manage().Window.Maximize();
                webDriver.Manage().Cookies.DeleteAllCookies();
            }
            else
            {

                DesiredCapabilities cap = null;
                if (bName.Equals("Mozilla"))
                {
                    cap = DesiredCapabilities.Firefox();
                    cap.SetCapability(CapabilityType.BrowserName, "firefox");
                    cap.SetCapability(CapabilityType.Platform, "WINDOWS");
                }
                else if (bName.Equals("Chrome"))
                {
                    cap = DesiredCapabilities.Chrome();
                    cap.SetCapability(CapabilityType.BrowserName, "chrome");
                    cap.SetCapability(CapabilityType.Platform, "WINDOWS");
                }

                try
                {
                    webDriver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), cap);
                    webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                    webDriver.Manage().Window.Maximize();
                }
                catch (Exception e)
                {
                    Log.Info(e);
                }
            }
            return webDriver;
        }
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
        static string getFilePath()
        {
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            string[] str = projectPath.Split('\\');


            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < str.Length - 2; i++)
            {
                sb.Append(str[i] + "\\");

            }


            Log.Info(projectPath);
            Log.Info(sb.ToString());
            return sb.ToString();
        }
       
    }
}
//public static IWebDriver WebDriver { get => webDriver; set => webDriver = value; }
// }
//public static IWebDriver WebDriver { get => webDriver; set => webDriver = value; }
//  }
