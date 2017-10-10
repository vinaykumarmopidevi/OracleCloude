using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using HireAnEmployee.TestDataAccess;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tests.PageObjects
{
   public class EmployementInformation
    {
        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Hire an Employee: Employment Information')]")]
        private IWebElement hireanemployeeEmploymentInformation;

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Hire an Employee: Compensation and Other Information')]")]
        private IWebElement hireanemployeeCompensationInformation;

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Hire an Employee: Review')]")]
        private IWebElement hireanemployeeReview;
        
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:2:pt1:sP2:NewPe3:0:NewPe1:0:businessUnitId::content")]
        private IWebElement businessunit;

        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:2:pt1:sP2:NewPe3:0:JobDe1:0:positionId::content")]
        private IWebElement position;

        [FindsBy(How = How.XPath, Using = "//*[@accesskey='x']")]
        private IWebElement clicknext3;

        [FindsBy(How = How.XPath, Using = "//*[@accesskey='x']")]
        private IWebElement clicknext4;

        [FindsBy(How = How.XPath, Using = "//*[@accesskey='m']")]
        private IWebElement submitbutton;
        
        [FindsBy(How = How.XPath, Using = "//*[@accesskey='Y']")]
        private IWebElement submityesbutton;
        
        [FindsBy(How = How.XPath, Using = "//*[@accesskey='K']")]
        private IWebElement submitokbutton;

        [FindsBy(How = How.Id, Using = "_FOpt1:_UIScmil1u::icon")]
       
        private IWebElement signoutimageclick;
        
        [FindsBy(How = How.Id, Using = "_FOpt1:_UISlg1")]
        private IWebElement signoutlinkclick;
        
        [FindsBy(How = How.Id, Using = "Confirm")]
        private IWebElement confirmbuttonclick;


        public string HireanemployeeEmploymentInformation
        {
            get { return hireanemployeeEmploymentInformation.Text; }
        }

        public bool IsAtHireanemployeeEmploymentInformation(string EmployeeEmploymentPage)
        {
            return HireanemployeeEmploymentInformation == EmployeeEmploymentPage;
        }

        public string HireanemployeeCompensationInformation
        {
            get { return hireanemployeeCompensationInformation.Text; }
        }

        public bool IsAtHireanemployeeCompensationInformation(string EmployeeCompensationPage)
        {
            return HireanemployeeCompensationInformation == EmployeeCompensationPage;
        }

        public string HireanemployeeReview
        {
            get { return hireanemployeeReview.Text; }
        }

        public bool IsAtHireanemployeeReview(string EmployeeReviewPage)
        {
            return HireanemployeeReview == EmployeeReviewPage;
        }

        public void Businessunit(String BusinessUnit)
        {
            System.Threading.Thread.Sleep(10000);
           // var userData = ExcelDataAccess.GetTestData(testName);
            //businessunit.SendKeys("US1 Business Unit");
            businessunit.SendKeys(BusinessUnit);
            System.Threading.Thread.Sleep(10000);
            businessunit.SendKeys(Keys.Tab);
            System.Threading.Thread.Sleep(20000);
        }

        public void Position()
        {
            System.Threading.Thread.Sleep(10000);
            position.SendKeys("Human Resources Senior Consultant");
            System.Threading.Thread.Sleep(10000);
            position.SendKeys(Keys.Tab);
            System.Threading.Thread.Sleep(30000);
        }
        public void ClickNext3()
        {
            System.Threading.Thread.Sleep(10000);
            clicknext3.Click();
            System.Threading.Thread.Sleep(10000);
        }
        public void ClickNext4()
        {
            System.Threading.Thread.Sleep(10000);
            clicknext4.Click();
            System.Threading.Thread.Sleep(10000);
        }
        public void SubmitButton()
        {
            System.Threading.Thread.Sleep(50000);
            submitbutton.Click();
            System.Threading.Thread.Sleep(10000);
        }
        public void SubmitYesButton()
        {
            System.Threading.Thread.Sleep(10000);
            submityesbutton.Click();
            System.Threading.Thread.Sleep(30000);
        }
        public void SubmitOKButton()
        {
            System.Threading.Thread.Sleep(12000);
            submitokbutton.Click();
            System.Threading.Thread.Sleep(20000);
        }
        public void Signoutimageclick()
        {
            System.Threading.Thread.Sleep(10000);
            signoutimageclick.Click();
            System.Threading.Thread.Sleep(10000);
        }
        public void Signoutlinkclick()
        {
            System.Threading.Thread.Sleep(10000);
            signoutlinkclick.Click();
            System.Threading.Thread.Sleep(10000);
        }
        public void Confirmbuttonclick()
        {
            System.Threading.Thread.Sleep(10000);
            confirmbuttonclick.Click();
            System.Threading.Thread.Sleep(10000);
        }
        
    }
}
