using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.TestHelpers.BaseClasses;
using Helpers.TestHelpers.Configuration;
using Helpers.TestHelpers.TestBaseUtility;
using Pages.Invoice;
using System.Configuration;
using Helpers.TestHelpers.Settings;

namespace Modules.Invoice
{
   public class InvoiceCreationModule
    {
        public void InvoicPage()
        {
            Invoice_Pages.WelcomePage.NavigateToWelcomePage();
            Invoice_Pages.WelcomePage.GotoPayable();
            Invoice_Pages.WelcomePage.GotoInvoiceWorkbench();
        }

       // private ILog Log = CommonBase.Log;
        public void loginToApplication()
        {
            Invoice_Pages.HomePage.GoTo();
            string instance = ReadXmlData.GetAttributeTestDataValue("//Setting/Data[@Info='Instance']");
            Invoice_Pages.HomePage.Login(ConfigurationManager.AppSettings.Get(AppConfigKeys.Username));
            Invoice_Pages.HomePage.Password(ConfigurationManager.AppSettings.Get(AppConfigKeys.Password));

            Invoice_Pages.HomePage.LoginButton();
            //Log.Info("logged in successfully");
        }

        public void logoutFromApplication()
        {
            Invoice_Pages.HomePage.Signoutimageclick();
            Invoice_Pages.HomePage.Signoutlinkclick();
            Invoice_Pages.HomePage.Confirmbuttonclick();
            Browser.Close();
        }

        public void InvoicWorknenchNav()
        {
            Invoice_Pages.invoiceWorkbenchPage.invoiceWorkBench_btn_click();
            Invoice_Pages.invoiceWorkbenchPage.invoiceWorkBench_link_click();

        }

    }
}
