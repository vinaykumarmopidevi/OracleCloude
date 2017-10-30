using NUnit.Framework;
using System;
using System.Collections.Generic;
using Helpers.TestHelpers;
using Helpers.TestHelpers.Configuration;
using Modules.CoreHR;
using Helpers.TestHelpers.TestBaseUtility;
using System.Windows.Forms;
using System;
using log4net;
using System.Threading;
using FluentAssertions;
using Helpers.TestHelpers.BaseClasses;
using log4net.Appender;
using SeleniumTests.OracleTestBase;


namespace SeleniumTests.CoreHR

{

    [TestFixture]
   // [Parallelizable(ParallelScope.Self)]
    public class HR_Hire_an_Employee : CommonBase
    {
        //Declare an instance for log4net
        
        //Declare an instance for log4net
        static string testName = "HireAnEmployee";
        

        [Test, TestCaseSource("getData"),
         Category("RegressionTests"), Category("SmokeTest"),
         Description("Ensure Hire An Emplyee creation successfully")]
        public void HR_Hire_an_Employee_Test(Dictionary<string, string> data)
        {
            Log.Info("Started scenario  execution");


            if (!DataUtil.isTestRunnable(xls, testName) || data["Runmode"].Equals("N"))
                Assert.Ignore("the scenario is Ignored from the current exdcution ");
            string brwname = ReadXmlData.GetAttributeTestDataValue("//Setting/Data[@Info='Browser']");
            Browser.GetDriver(brwname);
            // SeleniumTests.OracleTestBase.Singleton.GetInstance().Show();
            //Arrange (data)
            Random rnd = new Random();
            int rnd_num = rnd.Next(1000, 2000);
            string LastName = "TestUser" + rnd_num;


           // Arrange(modules)
            EmployeeCreationModule employee = new EmployeeCreationModule();

            //Act

            /*
             * login to application
             * 
             */

            Log.Info("login to application");
            employee.loginToApplication();

            /*
             * Entering Identification Details
             */

            Log.Info("Entering Identification details");
            employee.Identification_details(data["LegalEmployer"], LastName);

            /*
             * Entering PersonInformation Details
             */
            Log.Info("Entering PersonInformation details");
            employee.PersonInformation_details(data["AddressLine1"], data["Zipcode"]);
            /*
             * Entering EmployementInformation Details
             */
            Log.Info("Entering EmployementInformation details");
            employee.EmployementInformation_Details(data["BusinessUnit"]);

            /*
             * Business validation - verifying whether Employee has created successfully or not
             * Expected Result: Employee should create successfully
             */
            Log.Info("Entering SearchPersonName");
            employee.SearchPersonName(LastName);


            //Assert
            Log.Info("Verification Employee Creation");
           // Assert.IsTrue(employee.verificationEmployeeCreation(LastName), "Employeee created successful, pleas check!!");
            /*
             * Fluent Assertions
             */
            CoreHR_Pages.SearchPerson.getEmployeeName().Should().StartWith(LastName);
            
            /*
             * logout from application
             */
            employee.logoutFromApplication();
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
