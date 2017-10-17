using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using TestFrameworkTutorial.TestDataAccess;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tests.PageObjects.Payroll
{
   public class SearchPerson
    {
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
            Console.WriteLine("Expected Employee Name : '{0}'", expectedEmployeeName);
        }


        public void NameLink()
        {
             optainedEmplyeeName = namelink.Text;
             Console.WriteLine("Optained Employee Name : '{0}'", optainedEmplyeeName);
        }

        public void VerifyEmployee()
        {
            Pages.SearchPerson.NameLink();
            if (optainedEmplyeeName == expectedEmployeeName)
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Employee '{0}' created successfully", expectedEmployeeName);
                Console.WriteLine("*************************************");
            }
            else
            {
                Console.WriteLine("Employee doesn't Match");
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
