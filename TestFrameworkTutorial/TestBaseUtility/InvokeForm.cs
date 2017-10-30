using Helpers.TestHelpers.Configuration;
using System;
using System.IO;
using System.Windows.Forms;


namespace Helpers.TestHelpers.TestBaseUtility
{
    public class InvokeForm
    {
        public static string bName;
        public static string appShortName;
        private bool flag = false;
        public static void FormInvoke()
        {

            //File.AppendAllText(@"E:\Orbit\Hello.txt.txt", "VinayForm" + DateTime.Now.ToString("yyyyMMddHHmmss"));

            //DateTime.Now.ToString("yyyyMMddHHmmss"); // case sensitive
            // MessageBox.Show(DateTime.Now.ToString("MMddyyyy"));
            //string readText = File.ReadAllText(@"..\\..\\..\\ExecutionID.txt");

            string brwname = ReadXmlData.GetAttributeTestDataValue("//Setting/Data[@Info='Browser']");
             string instance = ReadXmlData.GetAttributeTestDataValue("//Setting/Data[@Info='Instance']");
             string timestamp = ReadXmlData.GetAttributeTestDataValue("//Setting/Data[@Info='Timestamp']");
            string currentTimeStamp = DateTime.Now.ToString("yyyyMMdd");

            if (!string.IsNullOrEmpty(timestamp) && !string.IsNullOrEmpty(brwname) && !string.IsNullOrEmpty(instance))
            {
                if (!currentTimeStamp.Equals(timestamp))
                {

                    ExecutionStartUpForm form;
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(form = new ExecutionStartUpForm());
                    appShortName = form.appShortName;
                    bName = form.browserName;
                }
                
            }
            else
            {
                ExecutionStartUpForm form;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(form = new ExecutionStartUpForm());
                appShortName = form.appShortName;
                bName = form.browserName;
            }

        }
    }
    
}
