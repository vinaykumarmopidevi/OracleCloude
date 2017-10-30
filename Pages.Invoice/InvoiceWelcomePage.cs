using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages.Invoice
{
   public class InvoiceWelcomePage
    {
        //Clicking on navigation link
        [FindsBy(How = How.XPath, Using = "//*[@id='pt1:_UISmmLink::icon']")]
        private IWebElement navigate_btn_click;

        //Clicking on payable link
        [FindsBy(How = How.XPath, Using = "//*[@id='groupNode_payables']")]
        private IWebElement payables_link_click;

        //click on invoice link
        [FindsBy(How = How.XPath, Using = "//*[@id='pt1:nv_itemNode_payables_payables_invoices']")]
        private IWebElement invoice_btn_click;

        public void NavigateToWelcomePage()
        {
            navigate_btn_click.Click();
        }

        public void GotoPayable()
        {
            payables_link_click.Click();
        }

        public void GotoInvoiceWorkbench()
        {
            invoice_btn_click.Click();
        }

    }
}
