using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.TestHelpers.CustomException
{
    public class InvalidBrowserWindowIndex : Exception
    {
        public InvalidBrowserWindowIndex(string msg) : base(msg) { }
    }
}
