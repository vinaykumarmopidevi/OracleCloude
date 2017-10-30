using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using Helpers.TestHelpers;
using Helpers.TestHelpers.BaseClasses;
using Pages.Benefits;



namespace Modules.Benefits
{
    public static class Pages
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

        public static Identification Identification
        {
            get
            {
                var identification = new Identification();
                PageFactory.InitElements(Browser.Driver, identification);
                return identification;
            }

        }

        //public static Class1 Class1
        //{
        //    get
        //    {
        //        var class1 = new Class1();
        //        PageFactory.InitElements(Browser.Driver, class1);
        //        return class1;
        //    }
        //}
        //public static SearchPerson SearchPerson
        //{
        //    get
        //    {
        //        var searchPerson = new SearchPerson();
        //        PageFactory.InitElements(Browser.Driver, searchPerson);
        //        return searchPerson;
        //    }
        //    set { }
        //}

        public static PersonInformation PersonInformation
        {
            get
            {
                var personInformation = new PersonInformation();
                PageFactory.InitElements(Browser.Driver, personInformation);
                return personInformation;
            }

        }
        public static EmployementInformation EmployementInformation
        {
            get
            {
                var employementInformation = new EmployementInformation();
                PageFactory.InitElements(Browser.Driver, employementInformation);
                return employementInformation;
            }

        }



        public static SearchPerson SearchPerson
        {
            get
            {
                var searchPerson = new SearchPerson();
                PageFactory.InitElements(Browser.Driver, searchPerson);
                return searchPerson;
            }
        }

        public static void Main(string[] args)
        {
            
        }

    }
}

