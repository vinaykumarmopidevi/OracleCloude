using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace Pages.CoreHR
{
    public class PersonInformation
    {
        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Hire an Employee: Person Information')]")]
        private IWebElement hireanemployeePersonalInformation;

        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:1:pt1:SP1:Perso2:0:Perso1:0:Maint1:0:i1:0:inputText17::content")]
        private IWebElement addressline1;

        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:1:pt1:SP1:Perso2:0:Perso1:0:Maint1:0:i1:1:inputText18::content")]
        private IWebElement addressline2;

        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:1:pt1:SP1:Perso2:0:Perso1:0:Maint1:0:i1:2:inputText19::content")]
        private IWebElement addressline3;

        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:1:pt1:SP1:Perso2:0:Perso1:0:Maint1:0:i1:5:inputComboboxListOfValues28::content")]
        private IWebElement zipcode;

        //id="_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:1:pt1:SP1:Perso2:0:Perso1:0:Maint1:0:i1:5:inputComboboxListOfValues28::content"

        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:1:pt1:SP1:Perso2:0:Perso1:0:Maint1:0:i1:5:inputComboboxListOfValues28::content")]
        private IWebElement geography;

        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:1:pt1:SP1:Perso2:0:Perso1:0:Maint1:0:i1:5:inputComboboxListOfValues28::_afrLovInternalQueryId:value00::content")]
        private IWebElement searchandselectsearchbutton;

        // [FindsBy(How = How.LinkText, Using = "New York, New York, NY")]
        //class="x2je"
        [FindsBy(How = How.XPath, Using = "//*[@class='x2je']")]
        private IWebElement searchandselect;

        [FindsBy(How = How.Id, Using = "_FOpt1:_FOr1:0:_FOSritemNode_workforce_management_new_person:0:MAnt2:1:pt1:pt_r1:1:pt1:SP1:Perso2:0:Perso1:0:Maint1:0:i1:5:inputComboboxListOfValues28::lovDialogId::ok")]
        private IWebElement searchandselectOKbutton;

        [FindsBy(How = How.XPath, Using = "//*[@accesskey='x']")]
        private IWebElement clicknext2;


        public string HireanemployeePersonalInformation
        {
            get { return hireanemployeePersonalInformation.Text; }
        }

        public bool IsAtHireanemployeePersonalInformation(string EmployeeIdentificationPage)
        {
            return HireanemployeePersonalInformation == EmployeeIdentificationPage;
        }

        public void AddressLine1(String AddressLine1)
        {
            //var userData = ExcelDataAccess.GetTestData(testName);
            System.Threading.Thread.Sleep(10000);
            //addressline1.SendKeys("Street1");
            addressline1.SendKeys(AddressLine1);
        }
        public void AddressLine2()
        {
            System.Threading.Thread.Sleep(10000);
            addressline2.SendKeys("Street2");
        }
        public void AddressLine3()
        {
            System.Threading.Thread.Sleep(10000);
            addressline3.SendKeys("Street3");
        }
        public void Zipcode(String Zipcode)
        {
            System.Threading.Thread.Sleep(5000);
           // var userData = ExcelDataAccess.GetTestData(testName);
            //zipcode.SendKeys("10010");
            zipcode.SendKeys(Zipcode);
            System.Threading.Thread.Sleep(5000);
            zipcode.SendKeys(Keys.Tab);
            System.Threading.Thread.Sleep(3000);
        }

        public void Geography()
        {
            //string current = driver.CurrentWindowHandle;
            //driver.FindElement(By.XPath("//*[@id='webtraffic_popup_start_button']")).Click();
            //Thread.Sleep(Sleep_Seconds);
            //popup = driver.CurrentWindowHandle;
            //Thread.Sleep(3000);
            //driver.SwitchTo().Window(current);
            //Thread.Sleep(1000);
            geography.Clear();
            System.Threading.Thread.Sleep(5000);
            geography.SendKeys("10010");
        }
        public void Searchandselectsearchbutton()
        {
            
            System.Threading.Thread.Sleep(5000);
            searchandselectsearchbutton.Click();
        }
        public void Searchandselect()
        {
            System.Threading.Thread.Sleep(10000);
            //foreach (string handle in driver.WindowHandles)
            //{
            //    IWebDriver popup = driver.SwitchTo().Window(handle);
            //    if (popup.Title.Contains("New Document Set: Project"))
            //    {
            //        break;
            //    }
            //}
            //tring firstWin = WebDriver.getWindowHandle();

            //Set<String> winHandle = driver.getWindowHandles();
            //winHandle.remove(firstWin);
            //String handle = winHandle.iterator().next();
            //if (handle != firstWin)
            //{
            //    String secondWin = handle;
            //    driver.switchTo().window(secondWin);
            //}



            searchandselect.Click();
        }        
        public void SearchandselectOKbutton()
        {
            System.Threading.Thread.Sleep(3000);
            searchandselectOKbutton.Click();
        }
        public void ClickNext2()
        {
            System.Threading.Thread.Sleep(3000);
            clicknext2.Click();
            System.Threading.Thread.Sleep(20000);
        }

    }
}
