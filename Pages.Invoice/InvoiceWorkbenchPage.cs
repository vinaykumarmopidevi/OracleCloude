using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Pages.Invoice
{
    public class InvoiceWorkbenchPage
    {

        //Clicking on navigation link
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:_FOTsdiitemNode_InvoiceWorkbench_FndTasksList::icon']")]
        private IWebElement invoice_wb_img_btn_click;

        //Clicking on navigation link
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:_FOTRaT:0:RAtl1']")]
        private IWebElement invoice_wb_link_btn_click;


        public void invoiceWorkBench_btn_click()
        {
            invoice_wb_img_btn_click.Click();
        }
        public void invoiceWorkBench_link_click()
        {
            invoice_wb_link_btn_click.Click();
        }
    }
}
