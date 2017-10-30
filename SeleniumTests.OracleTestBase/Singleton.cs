using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumTests.OracleTestBase
{
    public sealed class Singleton
    {
        public static Singleton instance = null;
        public static readonly object _lock = new object();
        public string LastName;
        public int rnd_num;
        private Singleton()
        {
            Random rnd = new Random();
            rnd_num = rnd.Next(1000, 2000);
            LastName = "TestUser" + rnd_num;


        }

        static Singleton()
        {
            // create the instance only if the instance is null
            instance = new Singleton();
        }

        public static Singleton GetInstance()
        {
            // return the already existing instance
            return instance;
        }

        public void Show()
        {
            MessageBox.Show(LastName);
        }

        
    }
}
