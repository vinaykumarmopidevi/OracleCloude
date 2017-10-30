using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Reflection;
using System.Windows.Forms;
using Helpers.TestHelpers;
using Helpers.TestHelpers.BaseClasses;
using Helpers.TestHelpers.Configuration;
using Helpers.TestHelpers.TestBaseUtility;
using Modules.AccountPayables;
using NUnit.Framework;
using SeleniumTests.OracleTestBase;


namespace SeleniumTests.AccountPayables
{
  
    [TestFixture]
    public class CreateSupplier : CommonBase
    {
        static string testName = "CreateSupplier";

        private static bool flag = false;
        
       
        [Test, TestCaseSource("getData"),
         Category("RegressionTests"),
         Description("Supplier Creation")]

        public void Create_Supplier(Dictionary<string, string> data)
        {
            if (!DataUtil.isTestRunnable(xls, testName) || data["Runmode"].Equals("N"))
                Assert.Ignore("the scenario is Ignored from the current exdcution ");
            string brwname = ReadXmlData.GetAttributeTestDataValue("//Setting/Data[@Info='Browser']");
            Browser.GetDriver(brwname);
            //Arrange(Module)CreateSupplierModule
            CreateSupplierModule supplierCreation = new CreateSupplierModule();
            supplierCreation.loginToApplication();
            supplierCreation.Navigation_Details();
            supplierCreation.CreateSupplier("Supplier" + GetRandomNumber(), data["BusinessRelationship"], data["TaxOrganizationType"], data["SupplierType"]);
            
            supplierCreation.AddressCreation(data["Address"], data["CountryName"], data["AddressLine1"], data["Pincode"]);
            supplierCreation.SiteCreation(data["Procurement"]);
            //supplierCreation.TransactionTax();
            supplierCreation.SiteAssignment(data["Client"]);
            supplierCreation.ContactDetails(data["FirstName"] , data["LastName"] );
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
