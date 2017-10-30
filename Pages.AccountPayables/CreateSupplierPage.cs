using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages.AccountPayables
{
    public class CreateSupplierPage
    {
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:_FOTRaT:0:dynam1:0:it1::content")]
        private IWebElement supplier;

        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:_FOTRaT:0:dynam1:0:soc2::content")]
        private IWebElement businessRelationship;

        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:_FOTRaT:0:dynam1:0:soc1::content")]
        private IWebElement taxOrganizationType;

        [FindsBy(How = How.Name, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:_FOTRaT:0:dynam1:0:countryNameId")]
        private IWebElement taxCountry;

        //Search and select tax country Name field
        [FindsBy(How = How.Name, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:_FOTRaT:0:dynam1:0:countryNameId::_afrLovInternalQueryId:value00")]
        private IWebElement searchandselectTaxCountryName;

        //Search and select tax country Code field
        [FindsBy(How = How.Name, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:_FOTRaT:0:dynam1:0:countryNameId::_afrLovInternalQueryId:value10")]
        private IWebElement searchandselectTaxCountryCode;

        //Search and select tax country Search Button
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:_FOTRaT:0:dynam1:0:countryNameId::_afrLovInternalQueryId::search")]
        private IWebElement searchandselectTaxCountrySearchButton;

        //Search and select tax country table selection
        [FindsBy(How = How.XPath, Using = "//div[contains(@id,'countryNameId_afrLovInternalTableId')]//span[contains(text(),'US')]")]
        private IWebElement searchandselectTaxCountryselectcountry;

        // Search and select tax country OK button click
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:_FOTRaT:0:dynam1:0:countryNameId::lovDialogId::ok")]
        private IWebElement searchandselectTaxCountryOkButton;

        //Tax registration Number
        [FindsBy(How = How.Name, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:_FOTRaT:0:dynam1:0:TaxReg")]
        private IWebElement taxRegistrationNumber;

        // Tax Payer ID
        [FindsBy(How = How.Name, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:_FOTRaT:0:dynam1:0:IncomeTaxId")]
        private IWebElement taxPayerId;

        //DUNS Number
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:_FOTRaT:0:dynam1:0:it2::content")]
        private IWebElement dunsNumber;

        //create Button Click
        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:_FOTRaT:0:dynam1:0:cb1")]
        private IWebElement createButtonClick;

        //Ignore Match Result and Create Supplier button

        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:MAt2:1:AP1:ctb2")]
        private IWebElement ignoreMatchResultandCreateSupplier;

        [FindsBy(How = How.Id, Using = "_FOpt1:_UIScmil1u::icon")]

        private IWebElement signoutimageclick;

        [FindsBy(How = How.Id, Using = "_FOpt1:_UISlg1")]
        private IWebElement signoutlinkclick;

        [FindsBy(How = How.Id, Using = "Confirm")]
        private IWebElement confirmbuttonclick;

        public void SupplierName(string SupplierName)
        {
            System.Threading.Thread.Sleep(8000);
            supplier.SendKeys(SupplierName);
        }

        public void BusinessRelationshipSelect(string BusinessRelations)
        {
            System.Threading.Thread.Sleep(1000);
            SelectElement BusinessRelationshipDropDown = new SelectElement(businessRelationship);
            //BusinessRelationshipDropDown.SelectByValue("0");
            BusinessRelationshipDropDown.SelectByText(BusinessRelations);
        }

        public void TaxOrganizationType(string taxOrgType)
        {

            System.Threading.Thread.Sleep(1000);
            SelectElement taxOrganizationTypeDropDown = new SelectElement(taxOrganizationType);
            //taxOrganizationTypeDropDown.SelectByValue("0");
            taxOrganizationTypeDropDown.SelectByText(taxOrgType);
        }

        public void TaxCountry()
        {
            System.Threading.Thread.Sleep(1000);
            taxCountry.SendKeys("United States Minor Outlying Islands");//United States
            taxCountry.SendKeys(Keys.Tab);
            System.Threading.Thread.Sleep(1000);
            //if (searchandselectTaxCountryName.Displayed)
            //{
            //    SearchandselectTaxCountryName();
            //    SearchandselectTaxCountryCode();
            //    SearchandselectTaxCountrySearchButton();
            //    SearchandselectTaxCountryselectcountry();
            //    SearchandselectTaxCountryOkButton();
            //}
        }

        public void SearchandselectTaxCountryName()
        {
            System.Threading.Thread.Sleep(1000);
            searchandselectTaxCountryName.SendKeys("United States Minor Outlying Islands"); //united States
        }
        public void SearchandselectTaxCountryCode()
        {
            System.Threading.Thread.Sleep(1000);
            searchandselectTaxCountryCode.SendKeys("UM"); //united States
        }

        public void SearchandselectTaxCountrySearchButton()
        {
            System.Threading.Thread.Sleep(1000);
            searchandselectTaxCountrySearchButton.Click(); //united States
        }

        public void SearchandselectTaxCountryselectcountry()
        {
            System.Threading.Thread.Sleep(1000);
            searchandselectTaxCountryselectcountry.Click(); //united States
        }

        public void SearchandselectTaxCountryOkButton()
        {
            System.Threading.Thread.Sleep(1000);
            searchandselectTaxCountryOkButton.Click(); //united States
        }

        public void TaxRegistrationNumber()
        {
            System.Threading.Thread.Sleep(1000);
            taxRegistrationNumber.SendKeys("United States Minor Outlying Islands");
        }
        public void TaxPayerId()
        {
            System.Threading.Thread.Sleep(1000);
            taxPayerId.SendKeys("UM");
        }

        public void DUNSNumber()
        {
            System.Threading.Thread.Sleep(5000);
            dunsNumber.SendKeys("1231231231231");
        }

        public void CreateButtonClick()
        {
            System.Threading.Thread.Sleep(1000);
            createButtonClick.Click();
            System.Threading.Thread.Sleep(8000);
            if (ignoreMatchResultandCreateSupplier.Displayed)
            {
                IgnoreMatchResultandCreateSupplier();
            }
        }

        public void IgnoreMatchResultandCreateSupplier()
        {
            ignoreMatchResultandCreateSupplier.Click();
            System.Threading.Thread.Sleep(8000);
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
