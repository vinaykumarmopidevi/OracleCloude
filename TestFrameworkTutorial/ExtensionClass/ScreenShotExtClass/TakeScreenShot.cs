using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestFrameworkTutorial.BaseClasses;
using TestFrameworkTutorial.ComponentHelper;

namespace TestFrameworkTutorial.ExtensionClass.ScreenShotExtClass
{
    public static class TakeScreenShot
    {
        public static void CaptureScreenShot(this PageBase baseClass, string name = null)
        {
            Thread.Sleep(200);
            GenericHelper.TakeSceenShot(name);
        }
    }
}
