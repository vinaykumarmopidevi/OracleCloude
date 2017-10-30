using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.TestHelpers;
using Helpers.TestHelpers.BaseClasses;
using Helpers.TestHelpers.Configuration;
using Helpers.TestHelpers.TestBaseUtility;
using log4net;

namespace Modules.AccountPayables
{
    public class CreateSupplierModule
    {
        private ILog Log = CommonBase.Log;
        public void loginToApplication()
        {
            AccountPayablesPages.HomePage.GoTo();
            string instance = ReadXmlData.GetAttributeTestDataValue("//Setting/Data[@Info='Instance']");
            AccountPayablesPages.HomePage.Login(ReadXmlData.GetAttributeValue("//catalog/cd[@shortname='" + instance + "']/username"));
            AccountPayablesPages.HomePage.Password(ReadXmlData.GetAttributeValue("//catalog/cd[@shortname='" + instance + "']/password"));

            AccountPayablesPages.HomePage.LoginButton();
            Log.Info("logged in successfully");
        }

        public void logoutFromApplication()
        {
            AccountPayablesPages.CreateSupplierPage.Signoutimageclick();
            AccountPayablesPages.CreateSupplierPage.Signoutlinkclick();
            AccountPayablesPages.CreateSupplierPage.Confirmbuttonclick();
            Browser.Close();
        }

        public void Navigation_Details()
        {
            AccountPayablesPages.WelcomePage.NavigatorImage();
            AccountPayablesPages.WelcomePage.ClickSupplier();
            AccountPayablesPages.WelcomePage.ClickTaskImage();
            AccountPayablesPages.WelcomePage.CreateSupplierLink();
        }

        public void CreateSupplier(string SupplierName,string BusinessRelations,string taxOrgType,string supplier)
        {
            AccountPayablesPages.CreateSupplierPage.SupplierName(SupplierName);
            AccountPayablesPages.CreateSupplierPage.BusinessRelationshipSelect(BusinessRelations);
            AccountPayablesPages.CreateSupplierPage.TaxOrganizationType(taxOrgType);
          //  AccountPayablesPages.CreateSupplierPage.TaxCountry();
            AccountPayablesPages.CreateSupplierPage.CreateButtonClick();
            AccountPayablesPages.EditSupplierPage.supplierTypeDropDown(supplier);
        }

        public void TransactionTax()
        {
            AccountPayablesPages.EditSupplierPage.TransactionTax();
            AccountPayablesPages.EditSupplierPage.ContolsAndDefaults();
            AccountPayablesPages.EditSupplierPage.AllowTaxApplicability();
            AccountPayablesPages.EditSupplierPage.Save();
        }

        public void AddressCreation(string address,string countryName,string adrs,string pincode)
        {
            AccountPayablesPages.EditSupplierPage.AddressesTabClick();
            AccountPayablesPages.EditSupplierPage.CreateAddressImageClick();
            AccountPayablesPages.EditSupplierPage.AddressName(address);
            //AccountPayablesPages.EditSupplierPage.Country(countryName);
            //AccountPayablesPages.EditSupplierPage.AddressLine1(adrs);
           // AccountPayablesPages.EditSupplierPage.PostalCode(pincode);
            AccountPayablesPages.EditSupplierPage.AddresspurposeOrdering();
            AccountPayablesPages.EditSupplierPage.AddresspurposeRemitTo();
            AccountPayablesPages.EditSupplierPage.Save();
        }

        public void SiteCreation(string Procurement)
        {
            // AccountPayablesPages.EditSupplierPage.ClickSiteTab();
            AccountPayablesPages.EditSupplierPage.ClickSitesActionAdd();
           //AccountPayablesPages.EditSupplierPage.ClickSitesScrollAdd();
           // AccountPayablesPages.EditSupplierPage.CreateSiteImageClick();
            AccountPayablesPages.EditSupplierPage.ProcurementBUDropDown(Procurement);
            //AccountPayablesPages.EditSupplierPage.SitePurposePurchasingCheckBox();
           // AccountPayablesPages.EditSupplierPage.SitePurposePayCheckBox();
           // AccountPayablesPages.EditSupplierPage.SitePurposePrimaryPayCheckBox();
            AccountPayablesPages.EditSupplierPage.SaveandcloseButtonClick();
            AccountPayablesPages.EditSupplierPage.ConfirmationOKButton();
        }

        public void SiteAssignment(string client)
        {
            AccountPayablesPages.EditSupplierPage.SiteTabClick();
            AccountPayablesPages.EditSupplierPage.SiteLinkClick();
            AccountPayablesPages.EditSupplierPage.SiteAssignmentTabClick();
            AccountPayablesPages.EditSupplierPage.SiteAssignmentCreateImageClick();
            AccountPayablesPages.EditSupplierPage.ClientBU(client);
            AccountPayablesPages.EditSupplierPage.SaveandcloseButtonClick();
            AccountPayablesPages.EditSupplierPage.ConfirmationOKButton();
        }

        public void ContactDetails(string firstName,string lastName)
        {
            AccountPayablesPages.EditSupplierPage.ContactsTabClick();
            AccountPayablesPages.EditSupplierPage.CreateContactsImageClick();
            AccountPayablesPages.EditSupplierPage.ContactsFirstName(firstName);
            AccountPayablesPages.EditSupplierPage.ContactsLastName(lastName);
            AccountPayablesPages.EditSupplierPage.Save();
            AccountPayablesPages.EditSupplierPage.ContactsSelectandAddImageClick();
            AccountPayablesPages.EditSupplierPage.ContactSelectandAddAddress();
            AccountPayablesPages.EditSupplierPage.SaveandcloseButtonClick();
            AccountPayablesPages.EditSupplierPage.ConfirmationOKButton();
            AccountPayablesPages.EditSupplierPage.Signoutimageclick();
            AccountPayablesPages.EditSupplierPage.Signoutlinkclick();
            AccountPayablesPages.EditSupplierPage.Confirmbuttonclick();
        }
    }
}
