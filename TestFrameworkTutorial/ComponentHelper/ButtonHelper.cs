using System;
using log4net;
using OpenQA.Selenium;
using Helpers.TestHelpers;
using Helpers.TestHelpers;
using Helpers.TestHelpers.Settings;

namespace Helpers.TestHelpers.ComponentHelper
{
    public class ButtonHelper
    {
        private static readonly ILog Logger = LoggerHelper.GetLogger(typeof(ButtonHelper));
        public static void ClickButton(By @by)
        {
            ObjectRepository.Driver.FindElement(@by).Click();
            Logger.Info(" Click on Element " + @by);
        }
    }
}
