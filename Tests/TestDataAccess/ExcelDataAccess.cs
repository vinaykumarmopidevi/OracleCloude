using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HireAnEmployee.TestDataAccess
{
    internal class ExcelDataAccess
    {

        //public static string TestDataFileConnection()
        //{
        //    var fileName = ConfigurationManager.AppSettings["E:\\VisualStudio\\POC\\Eduardo code\\OracleTestFrameworkTutorial\\stFrameworkTutorial\\TestDataAccess\\TestData.xlsx"];//TestDataSheetPath
        //    //E:\\VisualStudio\\POC\\Eduardo code\\OracleTestFrameworkTutorial\\TestFrameworkTutorial\\TestDataAccess\\TestData.xlsx
        //    var con =
        //        string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;",
        //            fileName);
        //    //var con =
        //    //   string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = E:\\VisualStudio\\POC\\Eduardo code\\OracleTestFrameworkTutorial\\stFrameworkTutorial\\TestDataAccess\\TestData.xlsx; Extended Properties=Excel 12.0;",
        //    //       fileName);
        //    //var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +fileName+ ";Extended Properties=\"Excel 12.0;HDR=Yes;\"");
        //    //var con = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);
        //    return con;
        //    // Provider = Microsoft.ACE.OLEDB.12.0; Data Source = c:\myFolder\myExcel2007file.xlsx;
        //    //Extended Properties = "Excel 12.0 Xml;HDR=YES";
        //   // return con;
        //}

        //public static UserData GetTestData(string keyName)
        //{
        //    using (var connection = new System.Data.OleDb.OleDbConnection(TestDataFileConnection()))
        //    { 
        //        connection.Open();
        //        var query = string.Format("select * from [DataSet$] where key='{0}'", keyName);
        //        var value = connection.Query<UserData>(query).FirstOrDefault();
        //        connection.Close();
        //        return value;
        //    }

        //}

        //public static UserData GetTestData(string keyName)
        //{
        //    var fileName = "E:/VisualStudio/HCM/OracleTestFrameworkTutorial/TestFrameworkTutorial/TestDataAccess/TestData.xlsx";
        //    var con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=Excel 12.0;";

        //    using (var connection = new System.Data.OleDb.OleDbConnection(con))
        //    {
        //        connection.Open();
        //        var query = string.Format("select * from [DataSet$] where key='{0}'", keyName);
        //        var value = connection.Query<UserData>(query).FirstOrDefault();
        //        connection.Close();
        //        return value;
        //    }

        //}

    }
}
