using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.TestHelpers;
using Helpers.TestHelpers.BaseClasses;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Windows.Forms;

namespace Pages.AccountPayables
{
    public class EditSupplierPage
    {
        //General Section
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt3:1:ap1:selectOneChoice4::content")]
        private IWebElement supplierType;

        //Profile Details - sub tab selection
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt3:1:ap1:sdProfileTransTaxTab::disAcr")]
        private IWebElement transactionTax;

        //Controls and Defaults sub Tab
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt3:1:ap1:pTxRg2:0:sdi1::disAcr")]
        private IWebElement contolsAndDefaults;

        //check box - Allow Tax Applicability
        [FindsBy(How = How.XPath, Using = "//input[@id='_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt3:1:ap1:pTxRg2:0:TaxPa1:0:sbc1::content']")]
        private IWebElement allowTaxApplicability;

        //Save 
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),\'Save\')]")]
        private IWebElement save;

        //Addresses Tab 
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt3:1:ap1:addressesTab::disAcr")]
        private IWebElement addressesTabClick;

        // Address Create Image 
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt3:1:ap1:r4:0:AT1:_ATp:create::icon")]
        private IWebElement createAdressImageClick;

        // Address Name
        [FindsBy(How = How.Name, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt3:2:AP1:it25")]
        private IWebElement addressName;

        //Country 
        [FindsBy(How = How.Name, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt3:2:AP1:soc8")]
        private IWebElement country;

        //Address Line 1
        [FindsBy(How = How.Name, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt3:2:AP1:i1:0:it3")]
        private IWebElement addressLine1;

        //Postal Code
        [FindsBy(How = How.Name, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt3:2:AP1:i1:4:geographyElement5Id")]
        private IWebElement postalCode;

        //INPUT Geography
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1: _FOr1:0:_FOSritemNode_procurement_suppliers: 0:MAt3: 2:AP1: i1:4:geographyElement5Id::_afrLovInternalQueryId:value00::content']")]
        private IWebElement geography_pincode;

        //Select from search and select window
        [FindsBy(How = How.XPath, Using = "//tr[@class=\'p_AFFocused p_AFSelected xe6\']")]
        private IWebElement searchandselectGeographySelection;

        //Search and select OK button
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt3:2:AP1:i1:4:geographyElement5Id::lovDialogId::ok")]
        private IWebElement searchandselectOKButton;

        // Address purpose - Ordering
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt3:2:AP1:smc11:_0")]
        private IWebElement addresspurposeOrdering;

        // Address purpose - Remit to
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt3:2:AP1:smc11:_1")]
        private IWebElement addresspurposeRemitTo;

        // Address purpose - RFQ or Bidding
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt3:2:AP1:smc11:_2")]
        private IWebElement addresspurposeRFQ;

        //Site tab
        [FindsBy(How = How.Id, Using = "//div[contains(.,'Sites')]")]
        private IWebElement clickSiteTab;

        //Create site Image
        [FindsBy(How = How.Id, Using = "//img[@id='_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt3:2:AP1:r4:0:AT3:_ATp:create::icon']")]
        private IWebElement createSiteImageClick;

        //Procurement BU
        [FindsBy(How = How.XPath, Using = "//select[contains(@id,'soc8::content')]")]
        private IWebElement procurementBU;

        //Site Purpose - Purchasing Check box
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:2:AP1:r4:0:AT3:_ATp:table3:0:sbc2::content")]
        private IWebElement sitePurposePurchasingCheckBox;

        // Site purpose - Pay Check box
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:2:AP1:r4:0:AT3:_ATp:table3:0:sbc5::content")]
        private IWebElement sitePurposePayCheckBox;

        //Site Purpose - Primary Pay
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:2:AP1:r4:0:AT3:_ATp:table3:0:sbc3::content")]
        private IWebElement sitePurposePrimaryPayCheckBox;

        // save and close Button
        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'ave and Close')]")]
        private IWebElement saveandcloseButtonClick;

        //confirmation button OK
        [FindsBy(How = How.XPath, Using = "//button[@accesskey='K']")]
        private IWebElement confirmationOKButton;

        // Site tab click from suppiler page
        [FindsBy(How = How.XPath, Using = "//a[contains(@id,'sitesTab') and contains(text(),'Sites')]")]
        private IWebElement siteTabClick;

        // Site link click in table
        //[FindsBy(How = How.XPath, Using = "//div[contains(@id,'procurement_suppliers:0:MAt9:1:ap1:r5:0:AT1:_ATp:SiteTbl')]//span[contains(text(),'COA address1')]")]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'COA address1')]")]
        private IWebElement siteLinkClick;

        // Site Assignments Tab
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:3:ap1:siteSDass::disAcr")]
        private IWebElement siteAssignmentTabClick;

        // Create Site Assignment image
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:3:ap1:r5:0:AT2:_ATp:create::icon")]
        private IWebElement siteAssignmentCreateImageClick;

        //Client BU
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:3:ap1:r5:0:AT2:_ATp:table2:0:cbuLov::content")]
        private IWebElement clientBU;

        // Bill-To BU
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:3:ap1:r5:0:AT2:_ATp:table2:0:bbuLov::content")]
        private IWebElement billtoBU;

        //Contacts Tab
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:1:ap1:contactsTab::disAcr")]
        private IWebElement contactsTabClick;

        //Contacts create Image Click
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:1:ap1:r8:0:AT2:_ATp:create::icon")]
        private IWebElement createContactsImageClick;

        // Contact First Name
        [FindsBy(How = How.Name, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:4:AP5:it9")]
        private IWebElement contactsFirstName;

        //Contact Last Name
        [FindsBy(How = How.Name, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:4:AP5:it8")]
        private IWebElement contactsLastName;



        // Sites Action
        [FindsBy(How = How.XPath, Using = "(//*[contains(text(),'Actions')])[1]")]
        private IWebElement sitesActionClick;



        // Contact Address Select and Add image
        [FindsBy(How = How.XPath, Using = "//div[@class='AFPopupMenuPopup']")]
        private IWebElement sitesActionscrollContentClick;

        // Contact Address Select and Add image
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:4:AP5:AT3:_ATp:ctb1::icon")]
        private IWebElement contactsSelectandAddImageClick;

        //Contact Select and Add Address textbox
        [FindsBy(How = How.Name, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:4:AP5:AT3:inputText1")]
        private IWebElement contactSelectandAddAddress;


        //Contact Select and Add Address Search Button
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:4:AP5:AT3:searchPotentialAddresses")]
        private IWebElement contactSelectandAddAddressSearchButton;

        //Contact Select and Add Address Select from search results
        [FindsBy(How = How.XPath, Using = "//div[contains(@id,'procurement_suppliers:0:MAt9:4:AP5:AT3:AT1:_ATp:t1')]//span[contains(text(),'COA address1')]")]
        private IWebElement contactSelectandAddAddressSelect;


        //Contact Select and Add Address Apply Button
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:4:AP5:AT3:applyAddressButton")]
        private IWebElement contactSelectandAddAddressApplyButton;


        //Contact Select and Add Address OK Button
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt9:4:AP5:AT3:ApplyAndDoneButton")]
        private IWebElement contactSelectandAddAddressOKButton;

        [FindsBy(How = How.Id, Using = "_FOpt1:_UIScmil1u::icon")]
        private IWebElement signoutimageclick;

        [FindsBy(How = How.Id, Using = "_FOpt1:_UISlg1")]
        private IWebElement signoutlinkclick;

        [FindsBy(How = How.Id, Using = "Confirm")]
        private IWebElement confirmbuttonclick;

        public void supplierTypeDropDown(string supplier)
        {
            System.Threading.Thread.Sleep(1000);
            SelectElement SupplierTypeDropDown = new SelectElement(supplierType);
            //BusinessRelationshipDropDown.SelectByValue("SUPPLIER");
            SupplierTypeDropDown.SelectByText(supplier);
        }
        public void TransactionTax()
        {
            System.Threading.Thread.Sleep(3000);
            transactionTax.Click();
        }
        public void ContolsAndDefaults()
        {
            System.Threading.Thread.Sleep(3000);

            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser.webDriver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            contolsAndDefaults.Click();
        }
        public void AllowTaxApplicability()
        {
          
            System.Threading.Thread.Sleep(3000);
            allowTaxApplicability.Click();
        }
        public void Save()
        {
         
            System.Threading.Thread.Sleep(8000);
            //IWebElement element = Browser.Driver.FindElement(By.XPath("//*[@id=\"_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:2:pt1:sP2:tt1:next\"]/a"));
            ((IJavaScriptExecutor)Browser.Driver).ExecuteScript("arguments[0].scrollIntoView(true);", save);

            save.Click();
        }
        public void AddressesTabClick()
        {
            System.Threading.Thread.Sleep(3000);
            addressesTabClick.Click();
        }
        public void CreateAddressImageClick()
        {
            System.Threading.Thread.Sleep(3000);
            createAdressImageClick.Click();
        }
        public void AddressName(string address)
        {
            System.Threading.Thread.Sleep(3000);
            addressName.SendKeys(address);
            var AddressName = addressName.Text;
            Console.WriteLine("************************************");
            Console.WriteLine("Address Name is : '{0}'", AddressName);
            Console.WriteLine("*************************************");
        }
        public void Country(string countryName)
        {
            System.Threading.Thread.Sleep(3000);
            country.SendKeys(countryName);
        }

        public void AddressLine1(string adrs)
        {
            System.Threading.Thread.Sleep(3000);
            addressLine1.SendKeys(adrs);
        }
        public void PostalCode(string pincode)
        {
            System.Threading.Thread.Sleep(3000);
            postalCode.SendKeys(pincode);
            System.Threading.Thread.Sleep(10000);
            //postalCode.SendKeys(Keys.Tab);
            //System.Threading.Thread.Sleep(8000);
           // geography_pincode.SendKeys(pincode);
           // SearchandselectGeographySelection();
           // SearchandselectOKButton();
            //if (searchandselectGeographySelection.Displayed)
            //{
            //    SearchandselectGeographySelection();
            //    SearchandselectOKButton();
            //}

        }
        public void SearchandselectGeographySelection()
        {
            System.Threading.Thread.Sleep(3000);
            searchandselectGeographySelection.Click();
        }

        public void SearchandselectOKButton()
        {
            System.Threading.Thread.Sleep(3000);
            searchandselectOKButton.Click();
        }
        public void AddresspurposeOrdering()
        {
            System.Threading.Thread.Sleep(3000);
            addresspurposeOrdering.Click();
        }
        public void AddresspurposeRemitTo()
        {
            System.Threading.Thread.Sleep(3000);
            addresspurposeRemitTo.Click();
        }
        public void AddresspurposeRFQ()
        {
            System.Threading.Thread.Sleep(3000);
            addresspurposeRFQ.Click();
        }

        public void ClickSiteTab()
        {
            System.Threading.Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser.webDriver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            clickSiteTab.Click();
        }

        public void ClickSitesActionAdd()
        {
            System.Threading.Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser.webDriver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");

            sitesActionClick.Click();
            System.Threading.Thread.Sleep(10000);
            // sitesActionClick.SendKeys(Keys.Enter);
            // System.Threading.Thread.Sleep(10000);
            ClickSitesScrollAdd();
        }
        public void ClickSitesScrollAdd()
        {
            System.Threading.Thread.Sleep(5000);
            sitesActionscrollContentClick.Click();
            System.Threading.Thread.Sleep(10000);
        }
        public void CreateSiteImageClick()
        {
            System.Threading.Thread.Sleep(8000);

            Actions action = new Actions(Browser.webDriver);
            action.MoveToElement(createSiteImageClick).Click().Build().Perform();

            createSiteImageClick.Click();
        }

        public void ProcurementBUDropDown(string Procurement)
        {
            System.Threading.Thread.Sleep(8000);
            if (!procurementBU.Displayed)
            {
               
                MessageBox.Show("Test");
            }
           // Actions action = new Actions(Browser.webDriver);
           // action.MoveToElement(createSiteImageClick).Perform();
           
                var ProcurementBUDropDown = new SelectElement(procurementBU);
           
            System.Threading.Thread.Sleep(8000);
            //BusinessRelationshipDropDown.SelectByValue("1");
            ProcurementBUDropDown.SelectByText(Procurement);
        }
        public void SitePurposePurchasingCheckBox()
        {
            System.Threading.Thread.Sleep(3000);
            if (sitePurposePurchasingCheckBox.Selected == false)
            {
                sitePurposePurchasingCheckBox.Click();
            }
        }
        public void SitePurposePayCheckBox()
        {
            System.Threading.Thread.Sleep(3000);
            if (sitePurposePayCheckBox.Selected == false)
            {
                sitePurposePayCheckBox.Click();
            }
        }
        public void SitePurposePrimaryPayCheckBox()
        {
            System.Threading.Thread.Sleep(3000);
            if (sitePurposePrimaryPayCheckBox.Selected == false)
            {
                sitePurposePrimaryPayCheckBox.Click();
            }
        }
        public void SaveandcloseButtonClick()
        {
            System.Threading.Thread.Sleep(3000);
            ((IJavaScriptExecutor)Browser.Driver).ExecuteScript("arguments[0].scrollIntoView(true);", saveandcloseButtonClick);

            saveandcloseButtonClick.Click();
        }
        public void ConfirmationOKButton()
        {
            System.Threading.Thread.Sleep(3000);
            confirmationOKButton.Click();
        }
        public void SiteTabClick()
        {
            System.Threading.Thread.Sleep(3000);
            siteTabClick.Click();
        }
        public void SiteLinkClick()
        {
            System.Threading.Thread.Sleep(3000);
            siteLinkClick.Click();
        }
        public void SiteAssignmentTabClick()
        {
            System.Threading.Thread.Sleep(3000);
            siteAssignmentTabClick.Click();
        }
        public void SiteAssignmentCreateImageClick()
        {
            System.Threading.Thread.Sleep(3000);
            siteAssignmentCreateImageClick.Click();
        }
        public void ClientBU(string Client)
        {
            System.Threading.Thread.Sleep(3000);
            clientBU.SendKeys(Client);
            clientBU.SendKeys(OpenQA.Selenium.Keys.Tab);
            System.Threading.Thread.Sleep(3000);
        }
        public void BilltoBU()
        {
            System.Threading.Thread.Sleep(3000);
            billtoBU.SendKeys("DELL BU02");
            billtoBU.SendKeys(OpenQA.Selenium.Keys.Tab);
            System.Threading.Thread.Sleep(3000);
        }

        public void ContactsTabClick()
        {
            System.Threading.Thread.Sleep(3000);
            contactsTabClick.Click();
        }
        public void CreateContactsImageClick()
        {
            System.Threading.Thread.Sleep(3000);
            createContactsImageClick.Click();
        }

        public void ContactsFirstName(string FirstName)
        {
            System.Threading.Thread.Sleep(3000);
            contactsFirstName.SendKeys(FirstName);
        }
        public void ContactsLastName(string LastName)
        {
            System.Threading.Thread.Sleep(3000);
            contactsLastName.SendKeys(LastName);
        }
        public void ContactsSelectandAddImageClick()
        {
            System.Threading.Thread.Sleep(3000);
            contactsSelectandAddImageClick.Click();
        }

        public void ContactSelectandAddAddress()
        {
            System.Threading.Thread.Sleep(3000);
            contactSelectandAddAddress.SendKeys("{AddressName}"); // need to pass captured address
            ContactSelectandAddAddressSearchButton();
            ContactSelectandAddAddressSelect();
            ContactSelectandAddAddressApplyButton();
            ContactSelectandAddAddressOKButton();
        }
        public void ContactSelectandAddAddressSearchButton()
        {
            System.Threading.Thread.Sleep(3000);
            contactSelectandAddAddressSearchButton.Click();
        }
        public void ContactSelectandAddAddressSelect()
        {
            System.Threading.Thread.Sleep(3000);
            contactSelectandAddAddressSelect.Click();
        }
        public void ContactSelectandAddAddressApplyButton()
        {
            System.Threading.Thread.Sleep(3000);
            contactSelectandAddAddressApplyButton.Click();
        }
        public void ContactSelectandAddAddressOKButton()
        {
            System.Threading.Thread.Sleep(3000);
            contactSelectandAddAddressOKButton.Click();
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
