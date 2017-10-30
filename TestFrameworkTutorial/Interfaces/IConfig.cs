using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers.TestHelpers;
using Helpers.TestHelpers.Configuration;

namespace Helpers.TestHelpers.Interfaces
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
