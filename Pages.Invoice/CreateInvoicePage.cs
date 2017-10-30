using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Pages.Invoice
{
    class CreateInvoicePage
    {

        //SET TEXT BOX VALUE
        //System.Threading.Thread.Sleep(5000);
            //driver.FindElement(By.XPath("")).SendKeys("DELL_BU01");

        //business unit
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:ic2::content']")]
        private IWebElement input_businessunit;
        //select the  desired value
        public void Enter_Businessunit()
        {
            input_businessunit.SendKeys("DELL_BU01");
        }
        //System.Threading.Thread.Sleep(10000);
        //  driver.FindElement(By.XPath("")).Click();
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:ic2::_afrautosuggestpopup']/li[2]")]
        private IWebElement choose_businessunit;
        public void Choose_Businessunit()
        {
            choose_businessunit.Click();
        }
        //select the box value

        //System.Threading.Thread.Sleep(5000);
        // driver.FindElement(By.XPath("")).SendKeys("DELL");
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:ic3::content']")]
        private IWebElement click_supplier;
        public void Click_Supplier()
        {
            choose_businessunit.SendKeys("DELL");
        }

        //select the  desired value

        // System.Threading.Thread.Sleep(5000);
        //  driver.FindElement(By.XPath("//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:ic3::_afrautosuggestpopup']/li[1]")).Click();

        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:ic3::_afrautosuggestpopup']/li[1]")]
        private IWebElement choose_loc;
        public void Choose_Loc()
        {
            choose_loc.Click();
        }

        // System.Threading.Thread.Sleep(5000);
        //  driver.FindElement(By.XPath("//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:i2::content']")).SendKeys("test23");
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:i2::content']")]
        private IWebElement input_invoice_num;
        public void Invoice_Num()
        {
            input_invoice_num.SendKeys("test23");
        }


        // System.Threading.Thread.Sleep(5000);
        //  driver.FindElement(By.XPath("//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:i3::content']")).SendKeys("200");

        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:i3::content']")]
        private IWebElement input_amt_num;
        public void Amount_Num()
        {
            input_amt_num.SendKeys("200");
        }


        // System.Threading.Thread.Sleep(5000);
        // driver.FindElement(By.XPath("")).SendKeys("Immediate");
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:r2:0:so3::content']")]
        private IWebElement input_pyt_mtd;
        public void Input_Payment()
        {
            input_pyt_mtd.SendKeys("Immediate");
        }
        // System.Threading.Thread.Sleep(5000);
        // driver.FindElement(By.XPath("")).SendKeys("100");
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:at2:_ATp:ta2:0:i26::content']")]
        private IWebElement input_LSA;
        public void Input_input_LSA()
        {
            input_LSA.SendKeys("100");
        }
        // System.Threading.Thread.Sleep(5000);
        // driver.FindElement(By.XPath("")).SendKeys("001-02-0001");
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:at2:_ATp:ta2:0:kf1CS::content']")]
        private IWebElement input_dest;
        public void Input_Dest()
        {
            input_dest.SendKeys("001-02-0001");
        }
        // System.Threading.Thread.Sleep(5000);
        // driver.FindElement(By.XPath("")).Click();
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:at2:_ATp:ta2::db']/table/tbody/tr[2]/td[4]")]
        private IWebElement link_img;
        public void Link_IMGPLUS()
        {
            link_img.Click();
        }
        //System.Threading.Thread.Sleep(5000);
        // driver.FindElement(By.XPath("")).SendKeys("100");
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:at2:_ATp:ta2:1:i26::content']")]
        private IWebElement input_LSA2;
        public void Input_LSA2()
        {
            input_LSA2.SendKeys("100");
        }

        //  System.Threading.Thread.Sleep(5000);
        //    driver.FindElement(By.XPath("")).SendKeys("001-02-0001");
        [FindsBy(How = How.XPath, Using = "//*[@id='_FOpt1:_FOr1:0:_FOSritemNode_payables_payables_invoices:0:MAnt2:1:pm1:r1:0:ap1:at2:_ATp:ta2:1:kf1CS::content']")]
        private IWebElement input_dest2;
        public void Input_Dest2()
        {
            input_dest2.SendKeys("001-02-0001");
        }
        
    }
}
