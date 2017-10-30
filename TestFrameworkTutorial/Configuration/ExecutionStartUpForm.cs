using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.SS.Formula.Functions;

namespace Helpers.TestHelpers.Configuration
{
    public partial class ExecutionStartUpForm : Form
    {
        public string appShortName;
        public string browserName;

        public ExecutionStartUpForm()
        {
            InitializeComponent();
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // SelectedValue = comboBox1.Text;
           // setBrowser(SelectedValue);
        }

        //public static void Main(string[] args)
        //{
        //    ExecutionStartUpForm form=new ExecutionStartUpForm();
        //    form.comboBox1_SelectedIndexChanged(null,EventArgs.Empty);
        //   Log.Info(form.getBrowser());
        //}

        //getter setter..... 
        public string getBrowser()
        {
            return browserName;

        }
        public void setBrowser(string SelectedValue)
        {
            this.browserName = SelectedValue;
        }


        public string getAppShortName()
        {
            return appShortName;

        }
        public void setAppShortName(string appShortName)
        {
            this.appShortName = appShortName;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"" + getFilePath() + "\\TestFrameworkTutorial\\EnvironmentDetails.xml", string.Empty);
            appShortName = comboBox1.Text;
            setAppShortName(appShortName);
            

            browserName = comboBox2.Text;
            setBrowser(browserName);
            //DateTime.Now.ToString("yyyyMMddHHmmss"); // case sensitive
            ReadXmlData.SetAttributeValue(browserName, appShortName, DateTime.Now.ToString("yyyyMMdd"));

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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


            
            return sb.ToString();
        }
    }
}
