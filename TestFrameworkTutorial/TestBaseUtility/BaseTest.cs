using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.TestHelpers;

namespace Helpers.TestHelpers.TestBaseUtility
{
    public class BaseTest
    {
        public static IWebDriver driver;
        static string _project_path = getProjectPath();

        static string _fileName = _project_path + @"TestDataAccess\Data.xlsx";
        public static ExcelReaderFile xls = new ExcelReaderFile(_fileName);
        public static bool gridRun = false;

        //public static IWebDriver openBrowser(string bName)
        //{
        //    if (!gridRun)
        //    {
        //        if (bName.Equals("Mozilla"))
        //        {
        //            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(_project_path + @"Resources\geckodriver\", "geckodriver.exe");
        //            //service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
        //            driver = new FirefoxDriver(service);

        //        }

        //        if (bName.Equals("Chrome"))
        //        {
        //            // string chromeDriver = getProjectPath() + @"Resources\chromedriver\";
        //            driver = new ChromeDriver(_project_path + @"Resources\chromedriver\");
        //        }

        //        if (bName.Equals("InternetExplorer"))
        //        {

        //            driver = new InternetExplorerDriver(_project_path + @"Resources\IEDriverServer\");

        //        }


        //        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        //        driver.Manage().Window.Maximize();

        //    }
        //    else
        //    {

        //        DesiredCapabilities cap = null;
        //        if (bName.Equals("Mozilla"))
        //        {
        //            cap = DesiredCapabilities.Firefox();
        //            cap.SetCapability(CapabilityType.BrowserName, "firefox");
        //            cap.SetCapability(CapabilityType.Platform, "WINDOWS");
        //        }
        //        else if (bName.Equals("Chrome"))
        //        {
        //            cap = DesiredCapabilities.Chrome();
        //            cap.SetCapability(CapabilityType.BrowserName, "chrome");
        //            cap.SetCapability(CapabilityType.Platform, "WINDOWS");
        //        }

        //        try
        //        {
        //            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), cap);
        //            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        //            driver.Manage().Window.Maximize();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //        }
        //    }
        //    return driver;
        //}
        public static string getProjectPath()
        {

            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            return projectPath;
        }
    }

}
