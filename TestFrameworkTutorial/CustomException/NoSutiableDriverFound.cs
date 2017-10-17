using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.TestHelpers
{
    public class NoSutiableDriverFound : Exception
    {
        public NoSutiableDriverFound(string msg) : base(msg)
        {

        }
    }
}
