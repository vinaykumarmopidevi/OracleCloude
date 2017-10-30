using System;
using Helpers.TestHelpers.TestBaseUtility;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace Pages.Benefits
{
    public class SearchPerson
    {
        private static log4net.ILog Log = CommonBase.Log;
        private static string PageTitle = "Search Person - Person Management";
        private static string optainedEmplyeeName;
        private static string expectedEmployeeName;
        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Person Management: Search')]")]
        //[FindsBy(How = How.XPath, Using = "//h1[contains(@text,'Person Management: Search')]")]
        private IWebElement personSearch;
                
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_person_management:1:MAt1:0:pt1:Perso1:0:SP3:q1:value00::content")]
        private IWebElement name;

        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_person_management:1:MAt1:0:pt1:Perso1:0:SP3:q1::search")]
        private IWebElement searchButton;

        [FindsBy(How = How.XPath, Using = "//a[contains(@id,'_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_person_management:1:MAt1:0:pt1:Perso1:0:SP3:table1:_ATp:table2:') and @class='xit']")]
                                                             
        private IWebElement namelink;

        public string PersonSearch
        {
            
            get {
                System.Threading.Thread.Sleep(30000);
                return personSearch.Text; }
        }

        public bool IsAtPersonSearch(string PersonSearchPage)
        {
            return PersonSearch == PersonSearchPage;
        }
        public void SearchPersonName(String LastName)
        {
            System.Threading.Thread.Sleep(10000);
          //  var userData = ExcelDataAccess.GetTestData(testName);
            name.Clear();
            name.SendKeys(LastName);
            System.Threading.Thread.Sleep(20000);
        }

        public void SearchButtonClick()
        {
            searchButton.Click();
            System.Threading.Thread.Sleep(20000);
        }

        public void verifyEmployeeName(String LastName)
        {
           // var employeeName = ExcelDataAccess.GetTestData(testName);
            System.Threading.Thread.Sleep(2000);
            expectedEmployeeName = LastName;
            Log.Info("Expected Employee Name : "+ expectedEmployeeName);
        }


        public void NameLink()
        {
             optainedEmplyeeName = namelink.Text;
             Log.Info("Optained Employee Name : "+ optainedEmplyeeName);
        }

        public void VerifyEmployee()
        {
            //Pages.SearchPerson.NameLink();
            if (optainedEmplyeeName == expectedEmployeeName)
            {
                Log.Info("*************************************");
                Log.Info("Employee  created successfully"+ expectedEmployeeName);
                Log.Info("*************************************");
            }
            else
            {
                Log.Info("Employee doesn't Match");
            }
        }
        //public string VerifyEmployeeLink
        //{
        //    get { return namelink.Text; }
        //}

        //public bool IsMatchedEmployeeName(string EmployeeName)
        //{
        //    return HireanemployeeEmploymentInformation == EmployeeEmploymentPage;
        //}

    }
}
