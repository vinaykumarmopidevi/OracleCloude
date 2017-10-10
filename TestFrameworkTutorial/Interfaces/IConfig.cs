using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFrameworkTutorial.Configuration;

namespace TestFrameworkTutorial.Interfaces
{
    public interface IConfig
    {
        BrowserType? GetBrowser();
        string GetUsername();
        string GetPassword();
        string GetWebsite();
        int GetPageLoadTimeOut();
        int GetImplicitElementLoadTimeout();
        int GetExplicitElementLoadTimeout();
        int GetElementLoadTimeOut();

    }
}
