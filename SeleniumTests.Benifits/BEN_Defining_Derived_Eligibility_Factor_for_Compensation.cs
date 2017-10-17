using NUnit.Framework;
using System.Collections.Generic;
using Helpers.TestHelpers;
using Helpers.TestHelpers.TestBaseUtility;

namespace SeleniumTests.Benefits
{
    [TestFixture]
   // [Parallelizable(ParallelScope.Self)]
    public class BEN_Defining_Derived_Eligibility_Factor_for_Compensation : BaseTest
    {
        static string testName = "HireAnEmployee_Test1";
        [Test, TestCaseSource("getData")]
        public void BEN_Defining_Derived_Eligibility_Factor_for_Compensation_Test(Dictionary<string, string> data)
        {   
           

            if (!DataUtil.isTestRunnable(xls, testName) || data["Runmode"].Equals("N"))
                Assert.Ignore("Runmode is No");

           // openBrowser(data["Browser"]);
           // Pages.HomePage.GoTo();
           // Pages.HomePage.Login(Configuration.ConfigurationManager.AppSettings["Username"]);
           // Pages.HomePage.Password(Configuration.ConfigurationManager.AppSettings["Password"]);
           // Pages.HomePage.LoginButton();


           // //Assert.IsTrue(Pages.HomePage.IsAtNavigatorPage("You have a new home page!"));
           // Console.WriteLine("logged in successfully");
           // Pages.Identification.NavigatorImage();
           // Pages.Identification.ClickNewPerson();
           // Console.WriteLine("Clicked on Navigator Image successfully");
           // Pages.Identification.ClickTaskImage();
           // Pages.Identification.ClickHireAnEmployee();
           // Assert.IsTrue(Pages.Identification.IsAtHireanemployeeIdentificationPage("Hire an Employee: Identification"));
           // Console.WriteLine("*****************Start of Hire an Employee: Identification page***************** ");
           // Console.WriteLine("Successfully navigated to Hire an Employee: Identification page");
           // Pages.Identification.HireDate();
           // Console.WriteLine("Entered hire date");
           // Pages.Identification.HireActionValue();
           // Console.WriteLine("Selected hire action  from dropdown");
           // Pages.Identification.HireReasonValue();
           // Console.WriteLine("Selected hire reason from dropdown");
           // Pages.Identification.LegalEmployer(data["LegalEmployer"]);
           // Console.WriteLine("Selected Legal Employer");
           // Pages.Identification.LastName(data["LastName"]);
           // Console.WriteLine("Selected Legal Employer");
           // Pages.Identification.ClickNext1();
           // Console.WriteLine("*****************End of Hire an Employee: Identification page***************** ");
           // Assert.IsTrue(Pages.PersonInformation.IsAtHireanemployeePersonalInformation("Hire an Employee: Person Information"));
           // Console.WriteLine("*****************Start of Hire an Employee: Person Information page***************** ");
           // Console.WriteLine("Successfully navigated to Hire an Employee: Person Information page");
           // Pages.PersonInformation.AddressLine1(data["AddressLine1"]);
           // Pages.PersonInformation.Zipcode(data["Zipcode"]);
           // // Pages.PersonInformation.Geography();
           // //Pages.PersonInformation.Searchandselectsearchbutton();
           // Pages.PersonInformation.Searchandselect();
           // Pages.PersonInformation.SearchandselectOKbutton();
           // Pages.PersonInformation.ClickNext2();
           // Console.WriteLine("*****************End of Hire an Employee: Person Information page***************** ");
           // Assert.IsTrue(Pages.EmployementInformation.IsAtHireanemployeeEmploymentInformation("Hire an Employee: Employment Information"));
           // Console.WriteLine("*****************Start of Hire an Employee: Employment Information page***************** ");
           // Console.WriteLine("Successfully navigated to Hire an Employee: Employment Information page");
           // Pages.EmployementInformation.Businessunit(data["BusinessUnit"]);
           // // Pages.EmployementInformation.Position();
           // Pages.EmployementInformation.ClickNext3();
           // Console.WriteLine("*****************End of Hire an Employee: Employment Information page***************** ");
           // Assert.IsTrue(Pages.EmployementInformation.IsAtHireanemployeeCompensationInformation("Hire an Employee: Compensation and Other Information"));
           // Console.WriteLine("*****************Start of Hire an Employee: Compensation and Other Information page***************** ");
           // Console.WriteLine("Successfully navigated to Hire an Employee: Compensation and Other Information page");
           // Pages.EmployementInformation.ClickNext4();
           // Console.WriteLine("*****************End of Hire an Employee: Compensation and Other Information page***************** ");
           // Assert.IsTrue(Pages.EmployementInformation.IsAtHireanemployeeReview("Hire an Employee: Review"));
           // Console.WriteLine("*****************Start of Hire an Employee: Review page***************** ");
           // Console.WriteLine("Successfully navigated to Hire an Employee: Review page");
           // Pages.EmployementInformation.SubmitButton();
           // Pages.EmployementInformation.SubmitYesButton();
           // Pages.EmployementInformation.SubmitOKButton();
           // Console.WriteLine("*****************End of Hire an Employee: Review page***************** ");
           // Pages.Identification.NavigatorImage();
           // Pages.Identification.Clickpersonmanagement();

           // Assert.IsTrue(Pages.SearchPerson.IsAtPersonSearch("Person Management: Search"));
           // Console.WriteLine("Successfully navigated to Person Management: Search page");
           // Pages.SearchPerson.SearchPersonName(data["LastName"]);
           // Pages.SearchPerson.SearchButtonClick();
           // Console.WriteLine("Successfully clicked search button in Person Management: Search page");
           // Pages.SearchPerson.verifyEmployeeName(data["LastName"]);
           // Pages.SearchPerson.VerifyEmployee();
           // Pages.EmployementInformation.Signoutimageclick();
           // Pages.EmployementInformation.Signoutlinkclick();
           // Pages.EmployementInformation.Confirmbuttonclick();
           //// Browser.Close();





        }

        public static object[] getData()
        {
            return DataUtil.getData_old(xls, testName);
        }

        [TearDown]
        public void quit()
        {
            
        }
    }
}
