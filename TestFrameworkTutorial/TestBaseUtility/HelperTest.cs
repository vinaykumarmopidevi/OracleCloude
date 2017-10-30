using NUnit.Framework;
using System;
using System.Configuration;
using System.Windows.Forms;

using Helpers.TestHelpers.Configuration;

namespace Helpers.TestHelpers.TestBaseUtility
{
   
   

    public sealed class HelperTest
    {
        private static HelperTest instance = null;

        private HelperTest()
        {
           
        
            ExecutionStartUpForm form;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form = new ExecutionStartUpForm());
             
        
    }

        public static HelperTest GetInstance()
        {
            // create the instance only if the instance is null
            if (instance == null )
            {
                
                    instance = new HelperTest();
                   
               
                
            }
            // Otherwise return the already existing instance
            return instance;
        }

       

    }
}