using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers.TestHelpers;
using Helpers.TestHelpers.Configuration;
using Helpers.TestHelpers.TestDataAccess;
using log4net;

namespace Helpers.TestHelpers.TestBaseUtility
{
    public class CommonBase 
    {

       
        public static readonly log4net.ILog Log = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
     

        public static IWebDriver driver;
        static string _project_path = getProjectPath();

        static string _fileName = _project_path + @"TestDataAccess\Data.xlsx";
        public static ExcelReaderFile xls = new ExcelReaderFile(_fileName);
        //Singleton s= Singleton.GetInstance();


        private static  int rnd_num = 0;
        private static  string getProjectPath()
        {

            //MessageBox.Show(DateTime.Now.ToString("yyyyMMddHHmmss"));
           // TextWriter tsw = new StreamWriter(@"D:\Hello.txt", true);
           // File.WriteAllText(@"..\\..\\..\\ExecutionID.txt", DateTime.Now.ToString("yyyyMMddHHmmss"));
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            return projectPath;
        }

        public int GetRandomNumber()
        {
            Random rnd = new Random();
            int rnd_num = rnd.Next(1000, 2000);
            return  rnd_num;
        }
    }

}
