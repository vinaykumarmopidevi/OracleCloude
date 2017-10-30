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
    public class WelcomePage
    {

        [FindsBy(How = How.XPath, Using = "//*[@id='pt1:_UISmmLink::icon']")]
        private IWebElement clicknavigator;

        [FindsBy(How = How.Id, Using = "pt1:nv_itemNode_procurement_suppliers")]
        private IWebElement clickSupplier;

        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:_FOTsdiPrcPozSuppliersDashboard__FndTasksList::icon")]
        private IWebElement clickTasksImage;

        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_procurement_suppliers:0:_FOTRaT:0:RAtl3")]
        private IWebElement createSupplier;
        public void NavigatorImage()
        {
            System.Threading.Thread.Sleep(8000);
            clicknavigator.Click();
        }

        public void ClickSupplier()
        {
            System.Threading.Thread.Sleep(8000);
            System.Threading.Thread.Sleep(8000);
            clickSupplier.Click();
        }

        public void ClickTaskImage()
        {
            System.Threading.Thread.Sleep(8000);
            clickTasksImage.Click();
        }

        public void CreateSupplierLink()
        {
            System.Threading.Thread.Sleep(8000);
            createSupplier.Click();

        }

    }
}
