using System;
using System.Text;

namespace SeleniumTests.OracleTestBase
{



    public  class HelperBaseClass
    {
        public Singleton singleton;

        public HelperBaseClass(Singleton singleton)
        {
            this.singleton = singleton;
        }
    }
}