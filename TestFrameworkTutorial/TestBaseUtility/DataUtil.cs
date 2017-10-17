using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.TestHelpers;

namespace Helpers.TestHelpers
{
    public class DataUtil
    {
        public static object[] getData_old(ExcelReaderFile xls, string testName)
        {

            //reads data for only testCaseName

            string sheetName = "Data";

            int testStartRowNum = 1;

            while (!xls.getCellData(sheetName, 0, testStartRowNum).Equals(testName))
            {
                testStartRowNum++;
            }
            Console.WriteLine("Test starts from row : " + testStartRowNum);

            int colStartRowNum = 1 + testStartRowNum;
            int dataStartRowNum = 2 + testStartRowNum;

            //calculate rows of data
            int rows = 0;
            while (!xls.getCellData(sheetName, 0, dataStartRowNum + rows).Equals(""))
            {
                rows++;

            }
            Console.WriteLine("Total rows :" + rows);

            //calculate total cols of data
            int cols = 0;
            while (!xls.getCellData(sheetName, cols, colStartRowNum).Equals(""))
            {
                cols++;
            }
            Console.WriteLine("Total cols :" + cols);

            //read the data

            object[][] data = new object[rows][];
            int dataRow = 0;
            Dictionary<string, string> table = null;

            for (int rNum = dataStartRowNum; rNum < dataStartRowNum + rows; rNum++)
            {
                data[rNum - dataStartRowNum] = new object[1];
                table = new Dictionary<string, string>();
                for (int cNum = 0; cNum < cols; cNum++)
                {
                    string key = xls.getCellData(sheetName, cNum, colStartRowNum);
                    string value = xls.getCellData(sheetName, cNum, rNum);
                    table.Add(key, value);
                }
                data[dataRow][0] = table;
                dataRow++;
                //0,0 0,1 0,2
                //1,0 1,1 1,2
            }
            return data;
        }
        public static object[] getData(ExcelReaderFile xls, string sheetName)
        {

            int rows = xls.getRowCount(sheetName);
            int cols = xls.getColumnCount(sheetName);

            object[][] data = new object[rows - 1][];


            for (int rNum = 2; rNum <= rows; rNum++)
            {
                data[rNum - 2] = new object[cols];
                for (int cNum = 0; cNum < cols; cNum++)
                {
                    string d = xls.getCellData(sheetName, cNum, rNum);
                    data[rNum - 2][cNum] = d;
                }
            }
            return data;
        }

        public static bool isTestRunnable(ExcelReaderFile xls, string testCaseName)
        {
            int rows = xls.getRowCount("TestCases");
            for (int rNum = 2; rNum <= rows; rNum++)
            {
                string currentTestCaseName = xls.getCellData("TestCases", "TCID", rNum);
                if (currentTestCaseName.Equals(testCaseName))
                {
                    string runmode = xls.getCellData("TestCases", "Runmode", rNum);
                    if (runmode.Equals("N"))
                        return false;
                    else
                        return true;
                }
            }
            return false;
        }

    }
}
