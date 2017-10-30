using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.TestHelpers.TestBaseUtility
{
    public class Singleton
    {
        private static Singleton instance = null;

        private Singleton()
        {
            File.WriteAllText(@"" + getFilePath() + "\\TestFrameworkTutorial\\EnvironmentDetails.xml", string.Empty);


        }

        public static Singleton GetInstance()
        {
            // create the instance only if the instance is null
            if (instance == null)
            {
                instance = new Singleton();
            }
            // Otherwise return the already existing instance
            return instance;
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
