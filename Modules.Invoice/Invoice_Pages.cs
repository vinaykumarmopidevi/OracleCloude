using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.TestHelpers.BaseClasses;
using Pages.Invoice;
using OpenQA.Selenium.Support.PageObjects;

namespace Modules.Invoice
{
    class Invoice_Pages
    {
        public static InvoiceWelcomePage WelcomePage
        {
            get
            {
                var homePage = new InvoiceWelcomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }

        }
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }

        }

        public static InvoiceWorkbenchPage invoiceWorkbenchPage
        {
            get
            {
                var InvoicePage = new InvoiceWorkbenchPage();
                PageFactory.InitElements(Browser.Driver, InvoicePage);
                return InvoicePage;
            }
        }
    }
}
