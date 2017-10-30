using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.TestHelpers;
using Helpers.TestHelpers.BaseClasses;
using OpenQA.Selenium.Support.PageObjects;
using Pages.AccountPayables;

namespace Modules.AccountPayables
{
    public class AccountPayablesPages
    {
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
                return homePage;
            }

        }
        public static WelcomePage WelcomePage
        {
            get
            {
                var welcomePage = new WelcomePage();
                PageFactory.InitElements(Browser.Driver, welcomePage);
                return welcomePage;
            }

        }

        public static CreateSupplierPage CreateSupplierPage
        {
            get
            {
                var createSupplierPage = new CreateSupplierPage();
                PageFactory.InitElements(Browser.Driver, createSupplierPage);
                return createSupplierPage;
            }

        }

        public static EditSupplierPage EditSupplierPage
        {
            get
            {
                var editSupplierPage = new EditSupplierPage();
                PageFactory.InitElements(Browser.Driver, editSupplierPage);
                return editSupplierPage;
            }

        }


    }
}
