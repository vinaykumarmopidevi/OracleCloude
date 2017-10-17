using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Helpers.TestHelpers;

namespace Pages.Benefits
{
    public class Identification
    {
        //IWebDriver webDrive;
        //public Identification(IWebDriver driver)
        //{
        //    this.webDrive = driver;
        //}

        public String EmployeePageTitle = "Hire an Employee - New Person - Oracle Applications";

        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_UISmmLink' or @id='pt1:_UISmmLink::icon']")]
        //_FOpt1:_UISmmLink, pt1:_UISmmLink::icon
        private IWebElement clicknavigator;

        [FindsBy(How = How.Id, Using = "pt1:nv_itemNode_workforce_management_new_person")]
        private IWebElement clicknewperson;

        [FindsBy(How = How.XPath, Using = "//*[@id='pt1:nv_itemNode_workforce_management_person_management' or @id='_FOpt1:nv_itemNode_workforce_management_person_management']")]
        private IWebElement clickpersonmanagement;
        //pt1:nv_itemNode_workforce_management_person_management
        //_FOpt1:nv_itemNode_workforce_management_person_management
        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Identification')]")]
        private IWebElement hireanemployeeIdentification;
        //Hire an Employee: 
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:_FOTsdiAddCwkDefaultRegional::icon")]
        private IWebElement clicktaskimage;

        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:_FOTRaT:0:RAtl1")]
        private IWebElement clickhireanemployee;

        [FindsBy(How = How.Name, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:0:pt1:SP1:inputDate1")]
        private IWebElement hiredatetext;
        
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:0:pt1:SP1:selectOneChoice1::content")]
        private IWebElement hireactionselect;
        
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:0:pt1:SP1:selectOneChoice2::content")]
        private IWebElement hirereasonselect;
        
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:0:pt1:SP1:selectOneChoice3::content")]
        private IWebElement legalEmployer;
        
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:0:pt1:SP1:NewPe1:0:pt_r1:0:r1:0:i1:4:it20::content")]
        private IWebElement lastname;

        [FindsBy(How = How.XPath, Using = "//*[@accesskey='x']")]
        private IWebElement clicknext1;

        public bool IsAtEmployeePage()
        {
            return Browser.Title == EmployeePageTitle;
        }
        public void NavigatorImage()
        {
            System.Threading.Thread.Sleep(20000);
            clicknavigator.Click();
        }

        public void ClickNewPerson()
        {
            System.Threading.Thread.Sleep(10000);
            clicknewperson.Click();
        }

        public void Clickpersonmanagement()
        {
            System.Threading.Thread.Sleep(20000);
            clickpersonmanagement.Click();
        }

        public void ClickTaskImage()
        {
            System.Threading.Thread.Sleep(10000);
            clicktaskimage.Click();
        }
        public void ClickHireAnEmployee()
        {
            System.Threading.Thread.Sleep(7000);
            clickhireanemployee.Click();
        }

        public string HireanemployeeIdentification
        {
           
            get {
                System.Threading.Thread.Sleep(20000);
                return hireanemployeeIdentification.Text; }
        }

        public bool IsAtHireanemployeeIdentificationPage(string EmployeeIdentificationPage)
        {
            return HireanemployeeIdentification == EmployeeIdentificationPage;
        }
        public void HireDate()
        {
            DateTime today = DateTime.Today; // As DateTime
            string HireDate = today.ToString("dd-MM-yyyy"); // As String

            System.Threading.Thread.Sleep(7000);
            hiredatetext.Clear();
            System.Threading.Thread.Sleep(2000);
            // hiredatetext.SendKeys("05/10/2017");
            // userData = ExcelDataAccess.GetTestData(testName);
            hiredatetext.SendKeys(HireDate);
        }
        public void HireActionValue()
        {
            
            System.Threading.Thread.Sleep(1000);
            SelectElement HireReasonValuedrop = new SelectElement(hireactionselect);
            HireReasonValuedrop.SelectByValue("0");
            
        }
        
        public void HireReasonValue()
        {
            
            System.Threading.Thread.Sleep(1000);
            SelectElement HireReasonValuedrop = new SelectElement(hirereasonselect);
            HireReasonValuedrop.SelectByValue("NEWHIRE");
           

        }

        public void LegalEmployer(string LegalEmployer)
        {
            System.Threading.Thread.Sleep(10000);
            //var userData = ExcelDataAccess.GetTestData(testName);
            legalEmployer.SendKeys(LegalEmployer);
            System.Threading.Thread.Sleep(20000);
            legalEmployer.SendKeys(Keys.Tab);
            System.Threading.Thread.Sleep(10000);
        }
        
        public void LastName(string LastName)
        {
            System.Threading.Thread.Sleep(7000);
           // var userData = ExcelDataAccess.GetTestData(testName);
            lastname.SendKeys(LastName);
            var name = lastname.Text;
            Console.WriteLine("************************************");
            Console.WriteLine("Creating an Employee: '{0}'", LastName);
            Console.WriteLine("*************************************");

        }

        
        public void ClickNext1()
        {
            System.Threading.Thread.Sleep(10000);
            clicknext1.Click();
            System.Threading.Thread.Sleep(20000);
        }
    }

    
}
