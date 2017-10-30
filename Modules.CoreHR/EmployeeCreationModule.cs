using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.TestHelpers;
using Helpers.TestHelpers.BaseClasses;
using Helpers.TestHelpers.Configuration;
using Helpers.TestHelpers.TestBaseUtility;
using log4net;

namespace Modules.CoreHR
{
   public class EmployeeCreationModule
   {
       private ILog Log = CommonBase.Log;
        public void loginToApplication()
        {
            CoreHR_Pages.HomePage.GoTo();
            string instance = ReadXmlData.GetAttributeTestDataValue("//Setting/Data[@Info='Instance']");
            CoreHR_Pages.HomePage.Login(ReadXmlData.GetAttributeValue("//catalog/cd[@shortname='" + instance + "']/username"));
            CoreHR_Pages.HomePage.Password(ReadXmlData.GetAttributeValue("//catalog/cd[@shortname='" + instance + "']/password"));

            CoreHR_Pages.HomePage.LoginButton();
            Log.Info("logged in successfully");
        }

        public void logoutFromApplication()
        {
            CoreHR_Pages.EmployementInformation.Signoutimageclick();
            CoreHR_Pages.EmployementInformation.Signoutlinkclick();
            CoreHR_Pages.EmployementInformation.Confirmbuttonclick();
            Browser.Close();
        }


        public void Identification_details(String LegalEmployer,string LastName)
        {
            /*
             * Entering Identification Details
             */
            CoreHR_Pages.Identification.NavigatorImage();
            CoreHR_Pages.Identification.ClickNewPerson();
            Log.Info("Clicked on Navigator Image successfully");
            CoreHR_Pages.Identification.ClickTaskImage();
            CoreHR_Pages.Identification.ClickHireAnEmployee();
            Log.Info("*****************Start of Hire an Employee: Identification page***************** ");
            Log.Info("Successfully navigated to Hire an Employee: Identification page");
            CoreHR_Pages.Identification.HireDate();
            Log.Info("Entered hire date");
            CoreHR_Pages.Identification.HireActionValue();
            Log.Info("Selected hire action  from dropdown");
            CoreHR_Pages.Identification.HireReasonValue();
            Log.Info("Selected hire reason from dropdown");
            CoreHR_Pages.Identification.LegalEmployer(LegalEmployer);
            Log.Info("Selected Legal Employer");
            CoreHR_Pages.Identification.LastName(LastName);
            Log.Info("Selected Legal Employer");
            CoreHR_Pages.Identification.ClickNext1();
            Log.Info("*****************End of Hire an Employee: Identification page***************** ");
            Log.Info("*****************Start of Hire an Employee: Person Information page***************** ");
            Log.Info("Successfully navigated to Hire an Employee: Person Information page");
        }


        public void PersonInformation_details(string AddressLine1, string Zipcode)
        {


            CoreHR_Pages.PersonInformation.AddressLine1(AddressLine1);
            CoreHR_Pages.PersonInformation.Zipcode(Zipcode);
            // Pages.PersonInformation.Geography();
            //Pages.PersonInformation.Searchandselectsearchbutton();
            CoreHR_Pages.PersonInformation.Searchandselect();
            CoreHR_Pages.PersonInformation.SearchandselectOKbutton();
            CoreHR_Pages.PersonInformation.ClickNext2();
            Log.Info("*****************End of Hire an Employee: Person Information page***************** ");

            Log.Info(
                "*****************Start of Hire an Employee: Employment Information page***************** ");
            Log.Info("Successfully navigated to Hire an Employee: Employment Information page");
        }

        public void EmployementInformation_Details(string BusinessUnit)
        {
            CoreHR_Pages.EmployementInformation.Businessunit(BusinessUnit);
            // Pages.EmployementInformation.Position();
            CoreHR_Pages.EmployementInformation.ClickNext3();
            Log.Info("*****************End of Hire an Employee: Employment Information page***************** ");

            Log.Info("*****************Start of Hire an Employee: Compensation and Other Information page***************** ");
            Log.Info("Successfully navigated to Hire an Employee: Compensation and Other Information page");
            CoreHR_Pages.EmployementInformation.ClickNext4();
            Log.Info("*****************End of Hire an Employee: Compensation and Other Information page***************** ");
            Log.Info("*****************Start of Hire an Employee: Review page***************** ");
            Log.Info("Successfully navigated to Hire an Employee: Review page");
            CoreHR_Pages.EmployementInformation.SubmitButton();
            CoreHR_Pages.EmployementInformation.SubmitYesButton();
            CoreHR_Pages.EmployementInformation.SubmitOKButton();
            Log.Info("*****************End of Hire an Employee: Review page***************** ");
            CoreHR_Pages.Identification.NavigatorImage();
            CoreHR_Pages.Identification.Clickpersonmanagement();
            Log.Info("Successfully navigated to Person Management: Search page");
        }

        public void SearchPersonName(string LastName)
        {
            CoreHR_Pages.SearchPerson.SearchPersonName(LastName);
            CoreHR_Pages.SearchPerson.SearchButtonClick();
            Log.Info("Successfully clicked search button in Person Management: Search page");
           // CoreHR_Pages.SearchPerson.verifyEmployeeName(LastName);
           // CoreHR_Pages.SearchPerson.VerifyEmployee();
        }

        public bool verificationEmployeeCreation(string LastName)
        {
            if (CoreHR_Pages.SearchPerson.getEmployeeName().Contains(LastName))
            {
                return true;
            }
            return false;
        }
        
    }
}
