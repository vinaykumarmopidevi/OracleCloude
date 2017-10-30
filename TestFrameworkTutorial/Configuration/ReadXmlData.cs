using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Helpers.TestHelpers.TestBaseUtility;
using OpenQA.Selenium.Remote;

namespace Helpers.TestHelpers.Configuration
{
    public class ReadXmlData
    {
        private static log4net.ILog Log = CommonBase.Log;
        public static string GetAttributeValue(string xpath)
        {
            try
            {
                //string wanted_path =
                //    Path.GetDirectoryName(
                //        Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));


                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(@"" + getFilePath() + "\\TestFrameworkTutorial\\AppData.xml");
                return xmldoc.SelectSingleNode(xpath).InnerText;

            }
            catch (Exception e)
            {
                Log.Info("Exception caught: {0}", e);
            }
            finally
            {
                Log.Info("Result: {0}");
            }
            return null;
        }

        public static string GetAttributeTestDataValue(string xpath)
        {
            try
            {
                //string wanted_path =
                //    Path.GetDirectoryName(
                //        Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())));


                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(@"" + getFilePath() + "\\TestFrameworkTutorial\\EnvironmentDetails.xml");
                return xmldoc.SelectSingleNode(xpath).InnerText;

            }
            catch (Exception e)
            {
                Log.Info("Exception caught: {0}", e);
            }
            finally
            {
                Log.Info("Result: {0}");
            }
            return null;
        }
        public static void SetAttributeValue(String bname, string instancename,string currentdate)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Setting");
            xmlDoc.AppendChild(rootNode);

            XmlNode userNode = xmlDoc.CreateElement("Data");
            XmlAttribute attribute = xmlDoc.CreateAttribute("Info");
            attribute.Value = "Browser";
            userNode.Attributes.Append(attribute);
            userNode.InnerText = bname;
            rootNode.AppendChild(userNode);

            userNode = xmlDoc.CreateElement("Data");
            attribute = xmlDoc.CreateAttribute("Info");
            attribute.Value = "Instance";
            userNode.Attributes.Append(attribute);
            userNode.InnerText = instancename;
            rootNode.AppendChild(userNode);

            userNode = xmlDoc.CreateElement("Data");
            attribute = xmlDoc.CreateAttribute("Info");
            attribute.Value = "Timestamp";
            userNode.Attributes.Append(attribute);
            userNode.InnerText = currentdate;
            rootNode.AppendChild(userNode);

            xmlDoc.Save(@"" + getFilePath() + "\\TestFrameworkTutorial\\EnvironmentDetails.xml");
        }

        public static void SetAttributeTimeStampValue(string timestamp)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Details");
            xmlDoc.AppendChild(rootNode);

            XmlNode userNode = xmlDoc.CreateElement("user");
            XmlAttribute attribute = xmlDoc.CreateAttribute("age");
            attribute.Value = "TimeStamp";
            userNode.Attributes.Append(attribute);
            userNode.InnerText = timestamp;
            rootNode.AppendChild(userNode);

           
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