using NUnit.Framework;
using System;
using System.Collections.Generic;
using Helpers.TestHelpers;
using Modules.CoreHR;
using System.Configuration;
using OpenQA.Selenium;
using Helpers.TestHelpers.TestBaseUtility;

namespace SeleniumTests.CoreHR
    
{
    [TestFixture]
   // [Parallelizable(ParallelScope.Self)]
    public class HR_Hire_an_Employee : BaseTest
    {
        static string testName = "HireAnEmployee";
        [Test, TestCaseSource("getData")]
        public void HR_Hire_an_Employee_Test(Dictionary<string, string> data)
        {   
           

            if (!DataUtil.isTestRunnable(xls, testName) || data["Runmode"].Equals("N"))
                Assert.Ignore("Runmode is No");

           // IWebDriver driver=openBrowser(data["Browser"]);
            CoreHR_Pages.HomePage.GoTo();
            CoreHR_Pages.HomePage.Login(ConfigurationManager.AppSettings["Username"]);
            CoreHR_Pages.HomePage.Password(ConfigurationManager.AppSettings["Password"]);
            //CoreHR_Pages.HomePage.Login("HCM_IMPL");
            //CoreHR_Pages.HomePage.Password("LhL49693");
            CoreHR_Pages.HomePage.LoginButton();


            // Assert.IsTrue(Pages.HomePage.IsAtNavigatorPage("You have a new home page!"));
            Console.WriteLine("logged in successfully");
            CoreHR_Pages.Identification.NavigatorImage();
            CoreHR_Pages.Identification.ClickNewPerson();
            Console.WriteLine("Clicked on Navigator Image successfully");
            CoreHR_Pages.Identification.ClickTaskImage();
            CoreHR_Pages.Identification.ClickHireAnEmployee();
            //Assert.IsTrue(CoreHR_Pages.Identification.IsAtHireanemployeeIdentificationPage("Hire an Employee: Identification"));
            Console.WriteLine("*****************Start of Hire an Employee: Identification page***************** ");
            Console.WriteLine("Successfully navigated to Hire an Employee: Identification page");
            CoreHR_Pages.Identification.HireDate();
            Console.WriteLine("Entered hire date");
            CoreHR_Pages.Identification.HireActionValue();
            Console.WriteLine("Selected hire action  from dropdown");
            CoreHR_Pages.Identification.HireReasonValue();
            Console.WriteLine("Selected hire reason from dropdown");
            CoreHR_Pages.Identification.LegalEmployer(data["LegalEmployer"]);
            Console.WriteLine("Selected Legal Employer");
            CoreHR_Pages.Identification.LastName(data["LastName"]);
            Console.WriteLine("Selected Legal Employer");
            CoreHR_Pages.Identification.ClickNext1();
            Console.WriteLine("*****************End of Hire an Employee: Identification page***************** ");
           // Assert.IsTrue(CoreHR_Pages.PersonInformation.IsAtHireanemployeePersonalInformation("Hire an Employee: Person Information"));
            Console.WriteLine("*****************Start of Hire an Employee: Person Information page***************** ");
            Console.WriteLine("Successfully navigated to Hire an Employee: Person Information page");
            CoreHR_Pages.PersonInformation.AddressLine1(data["AddressLine1"]);
            CoreHR_Pages.PersonInformation.Zipcode(data["Zipcode"]);
            // Pages.PersonInformation.Geography();
            //Pages.PersonInformation.Searchandselectsearchbutton();
            CoreHR_Pages.PersonInformation.Searchandselect();
            CoreHR_Pages.PersonInformation.SearchandselectOKbutton();
            CoreHR_Pages.PersonInformation.ClickNext2();
            Console.WriteLine("*****************End of Hire an Employee: Person Information page***************** ");
            //Assert.IsTrue(CoreHR_Pages.EmployementInformation.IsAtHireanemployeeEmploymentInformation("Hire an Employee: Employment Information"));
            Console.WriteLine("*****************Start of Hire an Employee: Employment Information page***************** ");
            Console.WriteLine("Successfully navigated to Hire an Employee: Employment Information page");
            CoreHR_Pages.EmployementInformation.Businessunit(data["BusinessUnit"]);
            // Pages.EmployementInformation.Position();
            CoreHR_Pages.EmployementInformation.ClickNext3();
            Console.WriteLine("*****************End of Hire an Employee: Employment Information page***************** ");
            //Assert.IsTrue(CoreHR_Pages.EmployementInformation.IsAtHireanemployeeCompensationInformation("Hire an Employee: Compensation and Other Information"));
            Console.WriteLine("*****************Start of Hire an Employee: Compensation and Other Information page***************** ");
            Console.WriteLine("Successfully navigated to Hire an Employee: Compensation and Other Information page");
            CoreHR_Pages.EmployementInformation.ClickNext4();
            Console.WriteLine("*****************End of Hire an Employee: Compensation and Other Information page***************** ");
           // Assert.IsTrue(CoreHR_Pages.EmployementInformation.IsAtHireanemployeeReview("Hire an Employee: Review"));
            Console.WriteLine("*****************Start of Hire an Employee: Review page***************** ");
            Console.WriteLine("Successfully navigated to Hire an Employee: Review page");
            CoreHR_Pages.EmployementInformation.SubmitButton();
            CoreHR_Pages.EmployementInformation.SubmitYesButton();
            CoreHR_Pages.EmployementInformation.SubmitOKButton();
            Console.WriteLine("*****************End of Hire an Employee: Review page***************** ");
            CoreHR_Pages.Identification.NavigatorImage();
            CoreHR_Pages.Identification.Clickpersonmanagement();

            //Assert.IsTrue(CoreHR_Pages.SearchPerson.IsAtPersonSearch("Person Management: Search"));
            Console.WriteLine("Successfully navigated to Person Management: Search page");
            CoreHR_Pages.SearchPerson.SearchPersonName(data["LastName"]);
            CoreHR_Pages.SearchPerson.SearchButtonClick();
            Console.WriteLine("Successfully clicked search button in Person Management: Search page");
            CoreHR_Pages.SearchPerson.verifyEmployeeName(data["LastName"]);
            CoreHR_Pages.SearchPerson.VerifyEmployee();
            CoreHR_Pages.EmployementInformation.Signoutimageclick();
            CoreHR_Pages.EmployementInformation.Signoutlinkclick();
            CoreHR_Pages.EmployementInformation.Confirmbuttonclick();
            // Browser.Close();





        }

        public static object[] getData()
        {
            return DataUtil.getData_old(xls, testName);
        }

        [TearDown]
        public void quit()
        {
            Browser.Close();
        }
    }
}
